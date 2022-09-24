using Confluent.Kafka;
using msa.PullZMQ.BackgroundTasks;
using msa.PullZMQ.Config;
using msa.PullZMQ.NetMQ;
using msa.PullZMQ.Utils;
using NetMQ.Sockets;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHostedService<PullZMQ>();
builder.Services.AddSingleton<IPullConfig>(sp =>
{
    // configuration.GetSection("NetMQConfig").ToString()
    var pullSocket = new PullSocket();
    pullSocket.Bind(builder.Configuration["NetMqConfig:Pull"]);
    return new NetPullConfig(pullSocket);
});
var producerAppSetting = builder.Configuration.GetSection("KafkaConfig").Get<KafkaConfig>();
var producerConfig = new ProducerConfig
{
    BootstrapServers = producerAppSetting.BootstrapServers,
};
builder.Services.AddSingleton<IKafkaProducer<string, string>>(sp =>
{
    var producer = new ProducerBuilder<string, string>(producerConfig).Build();
    return new KafkaProducer<string, string>(producer);
});
var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
