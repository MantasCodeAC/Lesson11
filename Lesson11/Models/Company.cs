using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Models
{
    internal class Company
    {
        public string OwnerCompanyName { get; set; }

        public int CompanyId { get; set; }

        public int CountryId { get; set; }
        public Company(string ownerCompanyName, int companyId, int countryId)
        {
            OwnerCompanyName = ownerCompanyName;
            CompanyId = companyId;
            CountryId = countryId;
        }
    }
}
