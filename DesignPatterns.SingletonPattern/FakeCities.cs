using DesignPatterns.SingletonPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    public class FakeCities
    {
        private static FakeCities instance = null;
        public static FakeCities Instance
        {
            get
            {
                if (instance is not null)
                {
                    // return existed
                    return instance;
                }
                else
                {
                    instance = new FakeCities();
                    return instance;
                }


            }

            set => instance = value;

        }

        public async Task<List<City>> GetCities()
        {
            await Task.Delay(2000);
            return new List<City>()
            {
                new City() { Name="Istanbul"},
                new City() { Name = "London"},
                new City() { Name="Berlin"}
            };
        }

        public async Task<City> GetCity()
        {
            return new City
            {
                Name = "New York"
            };
        }
    }
}
