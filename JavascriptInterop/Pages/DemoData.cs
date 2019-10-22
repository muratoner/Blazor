using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JavascriptInterop.Pages
{
    public class City
    {
        public string CityName { get; set; }

        public int Population { get; set; }
    }

    public class Country
    {
        public string CountryName { get; set; }

        public City[] Cities { get; set; }
    }

    public static class DemoData
    {
        public static List<Country> Data { get; } = new List<Country>
        {
            new Country
            {
                CountryName = "TR",
                Cities = new City[]
                {
                    new City
                    {
                        CityName = "İstanbul",
                        Population = 80000000
                    },
                    new City
                    {
                        CityName = "Kocaeli",
                        Population = 4000000
                    },
                    new City
                    {
                        CityName = "Van",
                        Population = 1000000
                    }
                }
            },
            new Country
            {
                CountryName = "UK",
                Cities = new []
                {
                    new City
                    {
                        CityName = "London",
                        Population = 7556900
                    },
                    new City
                    {
                        CityName = "Edinburgh",
                        Population = 464990
                    }
                }
            }
        };
    }

    public class TransformResult
    {
        public string CountryName { get; set; }

        public string CityName { get; set; }

        public int Population { get; set; }
    }
}
