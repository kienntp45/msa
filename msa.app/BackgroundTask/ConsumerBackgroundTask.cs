namespace msa.App.BackgroudTask
{
    public class ConsumerBackgroundTask : BackgroundService
    {
        private readonly IConfiguration _configuration;
        private readonly IKafkaConsumer<string, string> _kafkaConsumer;
        private readonly ILogger<ConsumerBackgroundTask> _logger;
        private readonly IServiceProvider _serviceProvider;

        public ConsumerBackgroundTask(IConfiguration configuration, IKafkaConsumer<string, string> kafkaConsumer, ILogger<ConsumerBackgroundTask> logger, IServiceProvider serviceProvider)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _kafkaConsumer = kafkaConsumer ?? throw new ArgumentNullException(nameof(kafkaConsumer));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    using var scope = _serviceProvider.CreateScope();
                    var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();// vi chua add dich vu duoc cho imediatr
                    var kafkaConfig = _configuration.GetSection("KafkaConfig").Get<KafkaConfig>();
                    var consumer = _kafkaConsumer.Consumer(kafkaConfig.Topic);
                    var pullTradingCashEntity = JsonConvert.DeserializeObject<TradingCash>(consumer.Message.Value);
                    _logger.LogInformation("nhan age kafka {0}", pullTradingCashEntity.Id);
                    var updateTradingCashCommand = new UpdateTradingCashCommand(pullTradingCashEntity.Id, pullTradingCashEntity.ClientCode, pullTradingCashEntity.CashAmount, pullTradingCashEntity.Advance, pullTradingCashEntity.RemainSecuritiesPower, pullTradingCashEntity.FSavingPower, pullTradingCashEntity.Adhoc, pullTradingCashEntity.MatchedBuy, pullTradingCashEntity.PendingBuy, pullTradingCashEntity.IntradayDebt, pullTradingCashEntity.PendingBuyDebt, pullTradingCashEntity.MatchedBuyFee, pullTradingCashEntity.PendingBuyFee, pullTradingCashEntity.InternalTransfer, pullTradingCashEntity.ExternalTransfer, pullTradingCashEntity.FeeSum, pullTradingCashEntity.CreditLine, pullTradingCashEntity.RemainDebt, pullTradingCashEntity.DebtInterest, pullTradingCashEntity.ReceivableT0, pullTradingCashEntity.ReceivableT1, pullTradingCashEntity.ReceivableT2, pullTradingCashEntity.ReceivableDividend, pullTradingCashEntity.ReceivableMatureCW, pullTradingCashEntity.ReceivableOddlot, pullTradingCashEntity.FSaving, pullTradingCashEntity.FSavingForPower, pullTradingCashEntity.BankSaving);
                    await mediator.Send(updateTradingCashCommand);
                    //await Task.Delay(5000);
                }
            }
            catch (OperationCanceledException)
            {

            }
           
        }
    }
}
