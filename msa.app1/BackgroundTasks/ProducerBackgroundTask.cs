namespace msa.app3.BackgroundTasks
{
    public class ProducerBackgroundTask : BackgroundService
    {
        private readonly IKafkaProducer<string, string> _kafkaProducer;
        private readonly ILogger<ProducerBackgroundTask> _logger;
        public ProducerBackgroundTask(IKafkaProducer<string, string> kafkaProducer, ILogger<ProducerBackgroundTask> logger)
        {
            _kafkaProducer = kafkaProducer;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var valueRd = Random();
                var tradiangCash = new TradingCash(valueRd,valueRd.ToString(),2002,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd,valueRd);
                _kafkaProducer.Producer(new Message<string, string> { Key = tradiangCash.Id.ToString(), Value = JsonConvert.SerializeObject(tradiangCash) }, "tradingCash");
                _logger.LogInformation("da pub {0}", tradiangCash.Id);
                await Task.Delay(2000);
            }
        }

        private int Random()
        {
            var rd = new Random();
            var value = rd.Next(1, 100);
            return value;
        }
    }
}
