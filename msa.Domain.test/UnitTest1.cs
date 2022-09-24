using msa.Domain.Aggregates;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.Extensions.Caching.Memory;

namespace msa.Domain.test
{
   
    public class UnitTest1
    {
      
        private void Data()
        {
            List<TradingCash> lstTradingCash = new List<TradingCash>();
            for (int i = 1; i <= 10; i++)
            {
                var valueToString = i.ToString();
                var tradingCash = new TradingCash(i,valueToString,i,i,i,i,i,i,i,i,i,i,i,i,i,i,i,i,i,i,i,i,i,i,i,i,i,i);
                lstTradingCash.Add(tradingCash);
            }

        }
        [Theory]
        [InlineData(8)]
        [InlineData(10)]
        public void Test1(long a)
        {
            var tradingCash = new TradingCash();
            tradingCash.CashAmount = 10;
            var rs = tradingCash.AddCashAmount(a);
            Assert.Equal(20, rs);
        }

    }
}