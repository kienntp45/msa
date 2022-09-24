namespace msa.App.Application.Commands
{
    public class ConfirmUpdateTradingCashCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public ConfirmUpdateTradingCashCommand(int id)
        {
            Id = id;
        }
    }
}
