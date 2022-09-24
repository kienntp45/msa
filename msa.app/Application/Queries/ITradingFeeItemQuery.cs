namespace msa.App.Application.Queries
{
    public interface ITradingFeeItemQuery
    {
        Task<TradingFeeItem> GetByIdAsync(int id);
        Task<List<TradingFeeItem>> GetAll();
    }
}
