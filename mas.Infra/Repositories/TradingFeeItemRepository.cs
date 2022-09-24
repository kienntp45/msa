namespace mas.Infra.Responsitories
{
    public class TradingFeeItemRepository : ITradingFeeItemRepository
    {
        private readonly Context _context;
        public IUnitOfWork UnitOfWork => _context;
        public TradingFeeItemRepository(Context context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
     

        public async Task<List<TradingFeeItem>> GetAll()
        {
            var tradingFeeItem = _context.TradingFeeItems.AsNoTracking().ToList();
            return tradingFeeItem;
        }

        public Task<TradingFeeItem> GetByIdAsync(int id)
        {
            var tradingFeeItem = _context.TradingFeeItems.FirstOrDefaultAsync(p => p.Id == id);
            return tradingFeeItem;
        }

        public TradingFeeItem UpdateTradingFeeItem(TradingFeeItem tradingFeeItem)
        {
            return _context.TradingFeeItems.Update(tradingFeeItem).Entity;
        }
    }
}
