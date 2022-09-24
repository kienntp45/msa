namespace msa.Common.Utils
{
    public interface IKafkaConsumer<TKey, TValue>
    {
        public ConsumeResult<TKey, TValue> Consumer(string topic, int partition = -1, long offset = -1, CancellationToken cancellation = default);
    }
}
