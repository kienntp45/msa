namespace msa.PullZMQ.Config
{
    public class KafkaConfig
    {
        public string BootstrapServers { get; set; }
        public string Topic { get; set; }
        public string GroupId { get; set; }
        public int Offset { get; set; }
        public int Partition { get; set; }
    }
}
