namespace msa.App.Application.IntegrationEvents.Events
{
    public class UpdateTradingCashConfirmedIntegrationEvent :IRequest<bool>
    {
        public int Id { get; set; }

        public UpdateTradingCashConfirmedIntegrationEvent(int id)
        {
            Id = id;
        }
    }
}
