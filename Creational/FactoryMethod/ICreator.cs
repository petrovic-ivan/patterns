namespace FactoryMethod
{
    public interface ICreator
    {
        IProduct FactoryMethod(int month);
    }
}