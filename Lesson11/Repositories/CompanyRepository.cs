using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson11.Models;

namespace Lesson11.Repositories
{
    internal class CompanyRepository
    {
        private List<Company> Companies = new List<Company>();
        public CompanyRepository()
        {
            Companies.Add(new Company("Airbus", 11, 101));
            Companies.Add(new Company("Boeing", 12, 102));
            Companies.Add(new Company("General Electric", 13, 103));
            Companies.Add(new Company("Bombardier", 14, 104));
            Companies.Add(new Company("Safran", 15, 105));
        }

        public Company Retrieve(int companyiD)
        {
            var talpykla = Companies[0];
            for (int i = 0; i < Companies.Count; i++)
            {
                if (Companies[i].CompanyId == companyiD)
                {
                    talpykla = Companies[i];
                }
            }
            return talpykla;
        }
        public List<Company> Retrieve()
        {
            return Companies;
        }
    }
}
