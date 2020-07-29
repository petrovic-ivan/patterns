namespace Flyweight
{
    // Real data about car.
    internal class CarContext
    {
        public CarContext(string vinNumber, CarFlyweight flyWeight)
        {
            this.VinNumber = vinNumber;
            this.Type = flyWeight;
        }

        public string VinNumber { get; } // Extristic data.
        public CarFlyweight Type { get; } // Intrinsic data.
    }
}