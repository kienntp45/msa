namespace msa.App.Application.Queries
{
    public interface ITradingCashQuery :ITradingCashInmemoryRepository
    {
        TradingCash GetByIdAsync(int id);
        TradingCash GetByClientCodeAsync(string clientCode);
        List<TradingCash> GetAll();
        
    }
}
