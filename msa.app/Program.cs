var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Netmq2(builder.Configuration);
//builder.Services.Netmq1(builder.Configuration);
builder.Services.AddKafkaConsumer(builder.Configuration);
builder.Services.AddKafkaProducer(builder.Configuration);
builder.Services.AddDI(builder.Configuration);
builder.Services.AddHealthChecks().AddOracle(builder.Configuration.GetConnectionString("connect"));
builder.Services.AddHealthChecks().AddCheck<HCapi>("api-get-all", null, new[] { "hc" });
builder.Services.AddHealthChecksUI(opt =>
{
    opt.SetEvaluationTimeInSeconds(10); //time in seconds between check    
    opt.MaximumHistoryEntriesPerEndpoint(60); //maximum history of checks    
    opt.SetApiMaxActiveRequests(1); //api requests concurrency    
    opt.AddHealthCheckEndpoint("api", "/health"); //map health check api    
}).AddInMemoryStorage();
var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapHealthChecks("/health", new HealthCheckOptions
{
    Predicate = _ => true,
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});
app.MapHealthChecksUI();
app.LaunchLoadindData();
app.Run();
