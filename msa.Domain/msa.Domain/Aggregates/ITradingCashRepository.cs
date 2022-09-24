namespace msa.Domain.Aggregates
{
    public interface ITradingCashRepository : IRepository<TradingCash>
    {
        TradingCash UpdateTradingCash(TradingCash tradingCash);
        TradingCash GetByIdAsync(int id);
        List<TradingCash> GetAll();
        public void AddTradingCashRange(List<TradingCash> tradingCash);
        public TradingCash GetByClientCodeAsync(string clientCode);

    }
}
