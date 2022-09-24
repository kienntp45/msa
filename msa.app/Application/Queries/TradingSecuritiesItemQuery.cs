namespace msa.App.Application.Queries
{
    public class TradingSecuritiesItemQuery : ITradingSecuritiesQuery
    {
        private readonly ITradingSecuritiesItemRepository _tradingSecuritiesItemReponsitory;
        public TradingSecuritiesItemQuery(ITradingSecuritiesItemRepository tradingSecuritiesItemReponsitory)
        {
            _tradingSecuritiesItemReponsitory = tradingSecuritiesItemReponsitory;
        }

        public async Task<List<TradingSecuritiesItem>> GetAll()
        {
            return await _tradingSecuritiesItemReponsitory.GetAll(); 
        }

        public async Task<TradingSecuritiesItem> GetByIdAsync(int id)
        {
          return await _tradingSecuritiesItemReponsitory.GetByIdAsync(id);
        } 
    }
}
