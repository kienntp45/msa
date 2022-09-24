namespace msa.App.Application.IntegrationEvents.Events.EventHandling
{
    public class UpdateTradingCashConfirmedIntegrationEventHandler : IRequestHandler<UpdateTradingCashConfirmedIntegrationEvent, bool>
    {
        private readonly IKafkaProducer<string, string> _kafkaProducer;
        private readonly ILogger<UpdateTradingCashConfirmedIntegrationEventHandler> _logger;

        public UpdateTradingCashConfirmedIntegrationEventHandler(ILogger<UpdateTradingCashConfirmedIntegrationEventHandler> logger, IKafkaProducer<string, string> kafkaProducer)
        {
            _logger = logger;
            _kafkaProducer = kafkaProducer;
        }

        public Task<bool> Handle(UpdateTradingCashConfirmedIntegrationEvent request, CancellationToken cancellationToken)
        {
            _kafkaProducer.Producer(new Message<string, string> { Key = request.Id.ToString(), Value = JsonConvert.SerializeObject(request.Id) }, "Confirm");
            _logger.LogInformation("IntegrationEvent");
            return Task.FromResult(true);
        }
    }


}
