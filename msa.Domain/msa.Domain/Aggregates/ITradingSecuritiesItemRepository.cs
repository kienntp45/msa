namespace msa.Domain.Aggregates
{
    public interface ITradingSecuritiesItemRepository:IRepository<TradingSecuritiesItem>
    {
        TradingSecuritiesItem UpdateTradingSecuritiesItem(TradingSecuritiesItem tradingSecuritiesItem);
        Task<TradingSecuritiesItem> GetByIdAsync(int id);
        Task<List<TradingSecuritiesItem>> GetAll();
    }
}
