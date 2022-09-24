namespace msa.App.Application.DomainEvents
{
    public class TradingCashModifiedDomainEventHandler : INotificationHandler<TradingCashModifiedDomainEvent>
    {
        private readonly ITradingCashRepository _tradingCashRepository;
        private readonly IMediator _mediator;
        private readonly ILogger<TradingCashModifiedDomainEventHandler> _logger;
        public static object _tradingCashEntity;
        private readonly IPushConfig _config;

        public TradingCashModifiedDomainEventHandler(ITradingCashRepository tradingCashRepository, IMediator mediator, ILogger<TradingCashModifiedDomainEventHandler> logger, IPushConfig config)
        {
            _tradingCashRepository = tradingCashRepository ?? throw new ArgumentNullException(nameof(tradingCashRepository));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _logger   = logger ?? throw new ArgumentNullException(nameof(logger));
            _config   = config ?? throw new ArgumentNullException(nameof(config));
        }

        async Task INotificationHandler<TradingCashModifiedDomainEvent>.Handle(TradingCashModifiedDomainEvent notification, CancellationToken cancellationToken)
        {
            var tradingCash = _tradingCashRepository.GetByIdAsync(notification.Id);
            if (tradingCash == null)
            {
                UpdateTradingCashCommandHandler._flag = false;
                return;
            }
            tradingCash.AddCashAmount(notification.CashAmount);// thay doi data
            _tradingCashRepository.UpdateTradingCash(tradingCash);
            _tradingCashEntity = tradingCash;
            _config.SendMessage(JsonConvert.SerializeObject(tradingCash));
            _logger.LogInformation("push netmq {0}",tradingCash.Id);
            await _tradingCashRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
            var updateTradingCashConfirmedIntegrationEvent = new UpdateTradingCashConfirmedIntegrationEvent(notification.Id);
            _logger.LogInformation("Send IntegrationEvent");
            await _mediator.Send(updateTradingCashConfirmedIntegrationEvent);
            return;
        }
    }
}
