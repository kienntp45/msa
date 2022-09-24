namespace msa.Domain.Aggregates
{
    public interface ITradingFeeItemRepository :IRepository<TradingFeeItem>
    {
        TradingFeeItem UpdateTradingFeeItem(TradingFeeItem tradingFeeItem);
        Task<TradingFeeItem> GetByIdAsync(int id);
        Task<List<TradingFeeItem>> GetAll();
    }
   
}
