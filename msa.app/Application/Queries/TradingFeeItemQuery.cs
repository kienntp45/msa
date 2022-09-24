namespace msa.App.Application.Queries
{
    public class TradingFeeItemQuery : ITradingFeeItemQuery
    {
        private readonly ITradingFeeItemRepository _tradingFeeItemReponsitory;
        public TradingFeeItemQuery(ITradingFeeItemRepository tradingFeeItemReponsitory)
        {
            _tradingFeeItemReponsitory = tradingFeeItemReponsitory;
        }
        public async Task<List<TradingFeeItem>> GetAll()
        {
            return await _tradingFeeItemReponsitory.GetAll();
        }

        public async  Task<TradingFeeItem> GetByIdAsync(int id)
        {
           return await _tradingFeeItemReponsitory.GetByIdAsync(id);
        }
    }
}
