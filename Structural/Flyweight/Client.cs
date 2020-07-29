using System;
using System.Collections.Generic;

namespace Flyweight
{
    internal static class Client
    {
        private  static List<CarContext> _cars = new List<CarContext>();

        public static void Run()
        {
            SellCar("ewqqweqwe", "Red", "Sedan");
            SellCar("ewedcxzr1", "White", "Sedan");
            SellCar("231ewqdsa", "White", "Sedan");
            SellCar("43ews2345", "Blue", "Sedan");
            SellCar("fdt43543t", "Black", "Sedan");

            DisplayAll();
        }

        private static void SellCar(string vin, string color, string type)
        {
            var carFlyweightType = CarFlyweightFactory.GetCarFlyweightType(color, type);
            var carContext = new CarContext(vin, carFlyweightType);
            _cars.Add(carContext);
        }

        private static void DisplayAll()
        {
            foreach (var car in _cars)
            {
                Console.WriteLine($"VIN: {car.VinNumber} COLOR: {car.Type.Color} TYPE: {car.Type.Type}.");
            }
        }
    }
}