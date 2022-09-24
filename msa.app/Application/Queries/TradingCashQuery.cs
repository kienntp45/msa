namespace msa.App.Application.Queries
{
    public class TradingCashQuery : ITradingCashQuery
    {
        private ITradingCashRepository _tradingCashReponsitory;
        private ITradingCashInmemoryRepository _tradingCashInmemoryRepository;
        private readonly Context _context;
        public IUnitOfWork UnitOfWork => _context;

        public TradingCashQuery(Context context, ITradingCashRepository tradingCashReponsitory, ITradingCashInmemoryRepository tradingCashInmemoryRepository)
        {
            _tradingCashReponsitory = tradingCashReponsitory ?? throw new ArgumentNullException(nameof(tradingCashReponsitory));
            _tradingCashInmemoryRepository = tradingCashInmemoryRepository;
            _context = context;
        }

        public List<TradingCash> GetAll()
        {
            return _tradingCashReponsitory.GetAll();
        }

        public TradingCash GetByClientCodeAsync(string clientCode)
        {
            return _tradingCashReponsitory.GetByClientCodeAsync(clientCode);
        }

        public TradingCash GetByClientCodeInMemoryAsync(string clientCode)
        {
            return _tradingCashInmemoryRepository.GetByClientCodeInMemoryAsync(clientCode);
        }

        public TradingCash GetByIdAsync(int id)
        {
            return _tradingCashReponsitory.GetByIdAsync(id);
        }

        public List<TradingCash> GetTradingCashMemoryCaChe()
        {
            return _tradingCashInmemoryRepository.GetTradingCashMemoryCaChe();
        }

        public List<TradingCash> GetTradingCashMemoryCaChe(int count)
        {
            return _tradingCashInmemoryRepository.GetTradingCashMemoryCaChe(count);
        }
    }
}
