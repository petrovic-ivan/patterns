namespace Decorator
{
    public class Client : IClient
    {
        private readonly IComponent _component;
        public Client(IComponent component)
        {
            _component = component;
        }

        public void Execute()
        {
            _component.DoWork();
        }
    }
}