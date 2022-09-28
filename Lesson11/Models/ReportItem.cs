using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Models
{
    internal class ReportItem
    {
        public string TailNumber { get; set; }
        public int ModelNumber { get; set; }
        public string ModelDescription { get; set; }
        public string OwnerCompanyName { get; set; }
        public string CompanyCountryCode { get; set; }
        public string CompanyCountryName { get; set; }
        public string InEuropeUnion { get; set; }

        /* public ReportItem(string tailNumber, int modelNumber, string modelDescription, 
           string ownerCompanyName, int companyCountryCode, string companyCountryName)
        {
            TailNumber = tailNumber;
            ModelNumber = modelNumber;
            ModelDescription = modelDescription;
            OwnerCompanyName = ownerCompanyName;
            CompanyCountryCode = companyCountryCode;
            CompanyCountryName = companyCountryName;
        }
    */
    }
}
