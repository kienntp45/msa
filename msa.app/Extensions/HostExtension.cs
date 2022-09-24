namespace msa.App.Extensions
{
    public static class HostExtension
    {   
        public static IHost LaunchLoadindData(this IHost host)
        {
           using (var scope = host.Services.CreateScope())
            {
                var dbContext= scope.ServiceProvider.GetRequiredService<Context>();
                var memory = scope.ServiceProvider.GetService<IMemoryCache>();
                var data = new DataLoader(memory,dbContext);
                data.LoadDataCashToMemory(dbContext.TradingCashs.ToList());
            }
            return host;
        }
    }
}
