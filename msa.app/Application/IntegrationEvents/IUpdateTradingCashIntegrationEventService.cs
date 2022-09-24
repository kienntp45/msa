namespace msa.App.Application.IntegrationEvents
{
    public interface IUpdateTradingCashIntegrationEventService
    {
        Task PublishEventsThroughEventBusAsync(Guid transactionId);
        Task AddAndSaveEventAsync(IntegrationEvent evt);
    }
}
