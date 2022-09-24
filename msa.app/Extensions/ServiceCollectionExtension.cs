namespace msa.App.Extensions
{
    public static class ServiceCollectionExtension
    {

        public static IServiceCollection AddDI(this IServiceCollection service, IConfiguration configuration)
        {

            service.AddDbContext<Context>(option =>
            {
                option.UseOracle(configuration.GetConnectionString("connect"));
                //option.UseSqlServer(configuration.GetConnectionString("connect"), opt => opt.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName));
            })
                  
            .AddAutoMapper(typeof(Mapping))
            .AddMediatR(typeof(UpdateTradingCashCommandHandler))
            .AddScoped<ITradingFeeItemRepository, TradingFeeItemRepository>()
            .AddScoped<ITradingCashRepository, TradingCashRepository>()
            .AddScoped<ITradingSecuritiesItemRepository, TradingSecuritiesItemRepository>()
            .AddTransient(typeof(ITradingFeeItemQuery), typeof(TradingFeeItemQuery))
            .AddScoped<ITradingCashInmemoryRepository, TradingCashInmemoryRepository>()
            .AddScoped<ITradingCashQuery, TradingCashQuery>()
            .AddScoped<IDataloader, DataLoader>()
            .AddMemoryCache()
            .AddScoped<ITradingSecuritiesQuery, TradingSecuritiesItemQuery>()
            .AddHostedService<ConsumerBackgroundTask>() // kafka 
            .AddHealthChecks()

             ;
            return service;
        }
       
        public static void Netmq2(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddSingleton<IPushConfig>(sp =>
            {
                var pushSocket = new PushSocket();
                pushSocket.Connect(configuration["NetMqConfig:Push"]);
                return new NetPushConfig(pushSocket);
            });
        }

        public static IServiceCollection AddKafkaProducer(this IServiceCollection services, IConfiguration configuration)
        {
            var producerAppSetting = configuration.GetSection("KafkaConfig").Get<KafkaConfig>();
            var producerConfig = new ProducerConfig
            {
                BootstrapServers = producerAppSetting.BootstrapServers,
            };
            services.AddSingleton<IKafkaProducer<string, string>>(sp =>
            {
                var producer = new ProducerBuilder<string, string>(producerConfig).Build();
                return new KafkaProducer<string, string>(producer);
            });
            return services;
        }
        public static IServiceCollection AddKafkaConsumer(this IServiceCollection services, IConfiguration configuration)
        {
            var kafkaConfig = configuration.GetSection("KafkaConfig").Get<KafkaConfig>();
            var consumerConfig = new ConsumerConfig
            {
                GroupId = kafkaConfig.GroupId,
                BootstrapServers = kafkaConfig.BootstrapServers,
                AutoOffsetReset = AutoOffsetReset.Earliest
            };
            services.AddSingleton<IKafkaConsumer<string, string>>(sp =>
            {
                var consumer = new ConsumerBuilder<string, string>(consumerConfig).Build();
                return new KafkaConsumer<string, string>(consumer);
            });
            return services;
        }

    }
}
