using Lesson11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Repositories
{
    internal class CountryRepository
    {
        private List<Country> Countries = new List<Country>();
        public CountryRepository()
        {
            Countries.Add(new Country("LT", "Lithuania", 101, true));
            Countries.Add(new Country("LV", "Latvia", 102, true));
            Countries.Add(new Country("RU", "Russia", 103, true));
            Countries.Add(new Country("UK", "United Kingdom", 104, false));
            Countries.Add(new Country("US", "United States", 105, false));
        }

        public Country Retrieve(int countryiD)
        {
            var talpykla = Countries[0];
            for (int i = 0; i < Countries.Count; i++)
            {
                if (Countries[i].CountryId == countryiD)
                {
                    talpykla = Countries[i];
                }
            }
            return talpykla;
        }
        public List<Country> Retrieve()
        {
            return Countries;
        }
    }
}
