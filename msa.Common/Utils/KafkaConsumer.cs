namespace msa.Common.Utils
{
    public class KafkaConsumer<TKey, TValue> : IDisposable, IKafkaConsumer<TKey, TValue>
    {
        private readonly IConsumer<TKey, TValue> _consumer;
        public KafkaConsumer(IConsumer<TKey, TValue> consumer)
        {
            _consumer = consumer;
        }

        public void Dispose()
        {
           _consumer.Dispose();
        }

        public ConsumeResult<TKey, TValue> Consumer( string topic,int partition =-1,long offset=-1,CancellationToken cancellation =default)
        {
            SetSubscribe(topic, partition, offset);
            while (!cancellation.IsCancellationRequested)
            {
                var result = _consumer.Consume(TimeSpan.FromSeconds(1));
                if (result !=null)
                {
                    _consumer.Commit(result);
                    return result; 
                }
            }
            return null;
        }
      
        public void SetSubscribe(string topic, int partition = -1, long offset = -1)
        {
            if (partition>=0)
            {
                if (offset>=0)
                {
                    _consumer.Assign(new TopicPartitionOffset(new TopicPartition(topic, partition), offset));
                }
                else
                {
                    _consumer.Assign(new TopicPartition(topic, partition));
                }
            }
            else
            {
                _consumer.Subscribe(topic);
            }
        }

    }
}
