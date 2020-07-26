namespace Proxy
{
    internal class Client : IClient
    {
        private readonly IProxy _proxy;

        public Client(IProxy proxy)
        {
            _proxy = proxy;
        }

        public void Execute()
        {
            _proxy.Request();
        }
    }
}