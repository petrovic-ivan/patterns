namespace Bridge
{
    internal interface IBridge
    {
        string OperationType { get; }
        void Operation();
    }
}