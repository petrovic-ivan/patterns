using System;
using System.Collections.Generic;

namespace PrototypePattern
{
    public static class Client
    {
        public static void Execute()
        {
            var lang1 = new Language("English", "EN-us");
            var usa1 = new Country("USA", "Washington", lang1);

            var lang2 = new Language("English", "EN-ca");
            var can1 = new Country("Canada", "Ottawa", lang2);

            CountryManager.Countries.Add("USA", usa1);
            CountryManager.Countries.Add("CAN", can1);

            var usa2 = CountryManager.Countries["USA"].DeepClone();
            var can2 = CountryManager.Countries["USA"].DeepClone();
            
            usa2.Name = "United States";
            usa2.Language.Name = "American";
            can2.Name = "Canada goose";
            can2.Language.Name = "Canadian";

            Console.WriteLine($"usa1.Name: {usa1.Name}, usa1.Language.Name: {usa1.Language.Name}");
            Console.WriteLine($"usa2.Name: {usa2.Name}, usa2.Language.Name: {usa2.Language.Name}");

            Console.WriteLine($"can1.Name: {can1.Name}, can1.Language.Name: {can1.Language.Name}");
            Console.WriteLine($"can2.Name: {can2.Name}, can2.Language.Name: {can2.Language.Name}");
        }
    }
}