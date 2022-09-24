namespace msa.App.NetMQ
{
    public class NetPushConfig : IDisposable,IPushConfig
    {
        private readonly PushSocket _pushSocket;

        public NetPushConfig(PushSocket config)
        {
            _pushSocket = config;
        }

        public void Dispose()
        {
           
        }

        public bool SendMessage(string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                return _pushSocket.TrySendFrame(message);
            }
            return false;
        }

    }
}
