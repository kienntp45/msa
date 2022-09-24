namespace msa.Domain.Aggregates.IInmemoryRepository
{
    public interface ITradingCashInmemoryRepository: IRepository<TradingCash>
    {
        public List<TradingCash> GetTradingCashMemoryCaChe();
        public List<TradingCash> GetTradingCashMemoryCaChe(int count);
        public TradingCash GetByClientCodeInMemoryAsync(string clientCode);
    }
}
