namespace msa.Infra.Data
{
    public interface IDataloader
    {
        public void LoadDataCashToMemory(List<TradingCash> tradingCashe);
        public void GetDataAgain();
    }
}
