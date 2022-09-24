namespace msa.App.HC
{
    public class HCapi : IHealthCheck
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public HCapi(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            //var isHealthy = true;
            var httpClient = _httpClientFactory.CreateClient();
            var response = httpClient.GetAsync("https://localhost:7102/api/TradingCash/get-all-tradingcash");
            var checkStatus = response.Result.StatusCode;
            //var checkStatusz1 = response.Result.IsSuccessStatusCode;
            if (checkStatus == System.Net.HttpStatusCode.OK)
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy("A healthy result."));
            }

            return Task.FromResult(
                new HealthCheckResult(context.Registration.FailureStatus, "An unhealthy result."));
        }
    }
}
