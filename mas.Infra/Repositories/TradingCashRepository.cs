namespace mas.Infra.Responsitories
{
    public class TradingCashRepository : ITradingCashRepository
    {
        private readonly Context _context;
        public IUnitOfWork UnitOfWork => _context;
        public TradingCashRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<TradingCash> GetAll()
        {
            var lstTradingCash = _context.TradingCashs.AsNoTracking().ToList();
            return lstTradingCash;
        }

        public TradingCash GetByIdAsync(int id)
        {
            var tradingCash = _context.TradingCashs.FirstOrDefault(p => p.Id == id);
            if (tradingCash == null)
            {
                tradingCash = _context.TradingCashs.Local.FirstOrDefault(p => p.Id == id);
            }
            return tradingCash;
        }

        public TradingCash GetByClientCodeAsync(string clientCode)
        {
            var tradingCash = _context.TradingCashs.FirstOrDefault(p => p.ClientCode == clientCode);
            if (tradingCash == null)
            {
                tradingCash = _context.TradingCashs.Local.FirstOrDefault(p => p.ClientCode == clientCode);
            }
            return tradingCash;
        }

        public TradingCash UpdateTradingCash(TradingCash tradingCash)
        {
            return _context.TradingCashs.Update(tradingCash).Entity;
        }
        public void AddTradingCashRange(List<TradingCash> tradingCash)
        {
            _context.TradingCashs.AddRange(tradingCash);
            _context.SaveChanges();
        }
    }
}
