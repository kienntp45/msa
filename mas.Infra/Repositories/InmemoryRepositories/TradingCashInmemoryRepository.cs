namespace msa.Infra.Repositories.InmemoryRepositories
{
    public class TradingCashInmemoryRepository : ITradingCashInmemoryRepository
    {
        private readonly IMemoryCache _memoryCache;
        private readonly Context _context;
        private readonly string cacheKey = "listTradingCash";
        private readonly IDataloader _dataloader;
        public IUnitOfWork UnitOfWork => _context;
        public TradingCashInmemoryRepository(IMemoryCache memoryCache, Context context,IDataloader dataloader)
        {
            _memoryCache = memoryCache;
            _context = context;
            _dataloader = dataloader;
        }

        public List<TradingCash> GetTradingCashMemoryCaChe(int count)
        {
            var data = new List<TradingCash>();
            data = _memoryCache.Get<List<TradingCash>>(cacheKey);
            if (data is null)
            {
                data = _context.TradingCashs.AsNoTracking().Take(count).ToList();
                _memoryCache.Set<List<TradingCash>>(cacheKey, data);
            }
            return data;
        }

        public List<TradingCash> GetTradingCashMemoryCaChe()
        {
            var data = new List<TradingCash>();
            data = _memoryCache.Get<List<TradingCash>>(cacheKey);
            if (data is null)
            {
                data = _context.TradingCashs.AsNoTracking().ToList();
                _memoryCache.Set<List<TradingCash>>(cacheKey,data);
            }
            return data;
        }

        public TradingCash GetByClientCodeInMemoryAsync(string clientCode)
        {
            var lstTradingCashMemory = _memoryCache.Get<List<TradingCash>>(cacheKey);
            var tradingCashExist = lstTradingCashMemory.FirstOrDefault(p => p.ClientCode.Equals(clientCode));
            if (tradingCashExist == null)
            {
                _dataloader.GetDataAgain();
                lstTradingCashMemory = _memoryCache.Get<List<TradingCash>>(cacheKey);
                tradingCashExist = lstTradingCashMemory.FirstOrDefault(p => p.ClientCode.Equals(clientCode));
                return tradingCashExist;
            }
            return tradingCashExist;
        }
    }
}
