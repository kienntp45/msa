namespace msa.App.Application.Commands
{
    public class ConfirmUpdateTradingCashCommandHandler : IRequestHandler<ConfirmUpdateTradingCashCommand,bool>
    {
       
        public ConfirmUpdateTradingCashCommandHandler()
        {
        
        }

        public Task<bool> Handle(ConfirmUpdateTradingCashCommand request, CancellationToken cancellationToken)
        {
            Console.WriteLine("ConfirmUpdateTradingCash");
            return Task.FromResult(true);
        }
    }
}
