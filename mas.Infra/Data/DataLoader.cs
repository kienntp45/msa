namespace msa.Infra.Data
{
    public class DataLoader : IDataloader
    {
        private readonly IMemoryCache _memoryCache;
        private readonly Context _context;
       
        public DataLoader(IMemoryCache memoryCache, Context context)
        {
            _memoryCache = memoryCache;
            _context = context;
        }

        public void LoadDataCashToMemory(List<TradingCash> tradingCashe)
        {
            var cacheKey = "listTradingCash";
            _memoryCache.Set(cacheKey, tradingCashe);
        }
        public void GetDataAgain()
        {
            var cacheKey = "listTradingCash";
            var tradigCashContext = _context.TradingCashs.ToList();
            _memoryCache.Set(cacheKey, tradigCashContext);
        }
    }
}
