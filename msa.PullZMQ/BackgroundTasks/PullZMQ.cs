using msa.PullZMQ.NetMQ;

namespace msa.PullZMQ.BackgroundTasks
{
    public class PullZMQ : BackgroundService
    {
        private readonly IPullConfig _pullConfig;

        public PullZMQ(IPullConfig pullConfig)
        {
            _pullConfig = pullConfig;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var a = _pullConfig.Receiver();
                Console.WriteLine("nhan age net mq {0}",a);
                await Task.Delay(5000);
            }
            
        }
    }
}
