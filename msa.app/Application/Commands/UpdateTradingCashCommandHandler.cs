namespace msa.App.Application.Commands
{
    public class UpdateTradingCashCommandHandler : IRequestHandler<UpdateTradingCashCommand,bool>
    {
        private readonly ITradingCashQuery _tradingCashQuery;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        private readonly ILogger<UpdateTradingCashCommandHandler> _logger;
        public static bool _flag = true;

        public UpdateTradingCashCommandHandler(ITradingCashQuery tradingCashQuery, IMapper mapper, ILogger<UpdateTradingCashCommandHandler> logger, IMediator mediator)
        {
            _tradingCashQuery = tradingCashQuery ?? throw new ArgumentNullException(nameof(tradingCashQuery));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<bool> Handle(UpdateTradingCashCommand command, CancellationToken cancellationToken)
        {
            Console.WriteLine("UpdateTradingCashCommandHandler");
            var tradingCash = _mapper.Map<TradingCash>(command);
            _logger.LogInformation("Map sang TradingCash {0}", tradingCash);
            var tradingCashModifiedDomainEvent = new TradingCashModifiedDomainEvent(tradingCash.Id, tradingCash.ClientCode, tradingCash.CashAmount, tradingCash.Advance, tradingCash.RemainSecuritiesPower, tradingCash.FSavingPower, tradingCash.Adhoc, tradingCash.MatchedBuy, tradingCash.PendingBuy, tradingCash.IntradayDebt, tradingCash.PendingBuyDebt, tradingCash.MatchedBuyFee, tradingCash.PendingBuyFee, tradingCash.InternalTransfer, tradingCash.ExternalTransfer, tradingCash.FeeSum, tradingCash.CreditLine, tradingCash.RemainDebt, tradingCash.DebtInterest, tradingCash.ReceivableT0, tradingCash.ReceivableT1, tradingCash.ReceivableT2, tradingCash.ReceivableDividend, tradingCash.ReceivableMatureCW, tradingCash.ReceivableOddlot, tradingCash.FSaving, tradingCash.FSavingForPower, tradingCash.BankSaving);
            await _mediator.Publish(tradingCashModifiedDomainEvent);
            if (_flag == false)
            {
                var rsThrow = new Throw(404, "Not found entity");
                return false;
            }
            _logger.LogInformation("Update entity {0}", tradingCashModifiedDomainEvent);
            await _tradingCashQuery.UnitOfWork.SaveEntitiesAsync(cancellationToken);
            _logger.LogInformation("tra ve TradingCashModifiedDomainEvent {0}", tradingCashModifiedDomainEvent);
            return true;
        }
    }
}
