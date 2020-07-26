namespace Bridge
{
    internal class Client : IClient
    {
        private readonly IAbstraction _abstraction;

        public Client(IAbstraction abstraction)
        {
            _abstraction = abstraction;
        }

        public void Execute()
        {
            _abstraction.Operation("airplane");
        }
    }
}