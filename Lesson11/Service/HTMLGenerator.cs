using Lesson11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Service
{
    internal class HTMLGenerator
    {
        public string GenerateHTMLWithColor(List<ReportItem> ataskaita)
        {
  
            string galutineAtaskaita = "";
            foreach (var x in ataskaita)
            {
                galutineAtaskaita = galutineAtaskaita + ("Aircraft Tail Number: " + x.TailNumber).ToString() + "\n" +
                ("Aircraft Model Number: " + x.ModelNumber).ToString()  + "\n" +
                ("Aircraft Model Description: " + x.ModelDescription).ToString() + "\n" +
                ("Owner Company Name: " + x.OwnerCompanyName).ToString() + "\n" +
                ("Company Country Code: " + x.CompanyCountryCode).ToString() + "\n" +
                ("Company Country Name: " + x.CompanyCountryName).ToString() + "\n" +
                x.InEuropeUnion + "\n" +
                ("-----------------------------------------------").ToString() + "\n";
            }

            return galutineAtaskaita;
        }

    }
}
