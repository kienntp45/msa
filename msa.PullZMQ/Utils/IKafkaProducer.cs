namespace msa.PullZMQ.Utils
{
    public interface IKafkaProducer<TKey, TValue>
    {
        public void Producer(Message<TKey, TValue> message, string topic);
    }
}
