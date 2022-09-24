namespace mas.Infra.Responsitories
{
    public class TradingSecuritiesItemRepository : ITradingSecuritiesItemRepository
    {
        private readonly Context _context;
        public IUnitOfWork UnitOfWork => _context;
        public TradingSecuritiesItemRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<TradingSecuritiesItem>> GetAll()
        {
            var lstTradingSecuritiesItems = _context.TradingSecuritiesItems.AsNoTracking().ToList();
            return lstTradingSecuritiesItems;
        }

        public Task<TradingSecuritiesItem> GetByIdAsync(int id)
        {
            var tradingSecuritiesItem = _context.TradingSecuritiesItems.FirstOrDefaultAsync(p => p.Id == id);
            return tradingSecuritiesItem;
        }

        public TradingSecuritiesItem UpdateTradingSecuritiesItem(TradingSecuritiesItem tradingSecuritiesItem)
        {
            return _context.TradingSecuritiesItems.Update(tradingSecuritiesItem).Entity;
        }
    }
}
