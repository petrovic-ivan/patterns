namespace FactoryMethod
{
    public interface IProduct
    {
        bool CanShip(int month);
        void ShipFrom();
    }
}