namespace msa.PullZMQ.NetMQ
{
    public class NetPullConfig : IDisposable, IPullConfig
    {
        private readonly PullSocket _pullSocket;
        public NetPullConfig(PullSocket pullSocket)
        {
            _pullSocket = pullSocket;
        }
        public void Dispose()
        {
           _pullSocket.Dispose();
        }
        public string Receiver()
        {
            return _pullSocket.ReceiveFrameString();
        }
    }
}
