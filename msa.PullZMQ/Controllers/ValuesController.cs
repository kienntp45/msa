namespace msa.PullZMQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IKafkaProducer<string, string> _kafkaProducer;
        private readonly IConfiguration _configuration;

        public ValuesController(IPullConfig pullConfig, IKafkaProducer<string, string> kafkaProducer, IConfiguration configuration)
        {
            _kafkaProducer = kafkaProducer;
            _configuration = configuration;
        }
        [HttpGet("/{mess}")]
        public IActionResult ProducerKafka(string mess)
        {
            var kafkaConfig = _configuration.GetSection("KafkaConfig").Get<KafkaConfig>();
            _kafkaProducer.Producer(new Message<string, string> { Key = "1", Value = mess }, kafkaConfig.Topic);
            return Ok(true);
        }

    }
}
