namespace _004._CitiesbyContCountry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CitiesbyContCountry
    {
        static void Main()
        {
            var numberInput = int.Parse(Console.ReadLine());
            var dictCities = new Dictionary<string,Dictionary<string, List<City>>>();
            //Fill dictionary
            for (int i = 0; i < numberInput; i++)
            {
                var inputString = Console.ReadLine().Split();
                var continetnName = inputString[0];
                var countryName = inputString[1];
                var cityName = inputString[2];
                var newCity = new City(continetnName, countryName, cityName);
                if (!dictCities.ContainsKey(continetnName))
                {
                    dictCities.Add(continetnName, new Dictionary<string,List<City>>());
                }
                if (!dictCities[continetnName].ContainsKey(countryName))
                {
                    dictCities[continetnName].Add(countryName, new List<City>());
                }
                dictCities[continetnName][countryName].Add(newCity);
            }

            //Print dictionary
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var continent in dictCities)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country  in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ",country.Value.Select(x=>x.Name))}");
                }
            }

        }
        public class City
        {
            public string continet;
            public string country;
            public string name;

            public City(string continent, string country, string name)
            {
                this.Continent = continent;
                this.Country = country;
                this.Name = name;

            }

            public string Continent { get; set; }
            public string Country { get; set; }
            public string Name { get; set; }

        }
    }
}
