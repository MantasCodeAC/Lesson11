using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Models
{
    internal class Country
    {
        public string CompanyCountryCode { get; set; }
        public string CompanyCountryName { get; set; }
        public int CountryId { get; set; }
        public bool InEurope { get; set; }
        public Country(string companyCountryCode, string companyCountryName, int countryId, bool inEurope)
        {
            CompanyCountryCode = companyCountryCode;
            CompanyCountryName = companyCountryName;
            CountryId = countryId;
            InEurope = inEurope;
        }
    }
}
