namespace msa.App.Application.Queries
{
    public interface ITradingSecuritiesQuery
    {
        Task<TradingSecuritiesItem> GetByIdAsync(int id);
        Task<List<TradingSecuritiesItem>> GetAll();
    }
}
