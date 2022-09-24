var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var producerConfig = new ProducerConfig
{
    BootstrapServers = "localhost:9092"
};
builder.Services.AddSingleton<IKafkaProducer<string, string>>(sp =>
{
      var producer = new ProducerBuilder<string, string>(producerConfig).Build();
      return new KafkaProducer<string, string>(producer);
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHostedService<ProducerBackgroundTask>(); // kafka 
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
