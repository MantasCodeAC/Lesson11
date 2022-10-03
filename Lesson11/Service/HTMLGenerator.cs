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

            string galutineAtaskaita = "<html><head><style>\r\n" +
                                        "table {\r\n  font-family: arial, sans-serif;" +
                                        "\r\n  border-collapse: collapse;" +
                                        "\r\n  width: 100%;" +
                                        "\r\n}\r\n\r\n" +
                                        "td, th {\r\n  " +
                                        "border: 1px solid #dddddd;" +
                                        "\r\n  text-align: left;" +
                                        "\r\n  padding: 8px;" +
                                        "</style></head><body><table>" +
                                        "<tr>" +
                                            "<th>Aircraft Tail Number</th>" +
                                            "<th>Aircraft Model Number</th>" +
                                            "<th>Aircraft Model Description</th>" +
                                            "<th>Owner Company Name</th>" +
                                            "<th>Company Country Code</th>" +
                                            "<th>Company Country Name</th>" +                                          
                                        "</tr>";
                                            

            foreach (var x in ataskaita)
            {
                galutineAtaskaita = galutineAtaskaita + 
                ($"<tr {x.InEuropeUnion}><td>" + x.TailNumber).ToString() + "</td>" +
                ("<td>" + x.ModelNumber).ToString()  + "</td>" +
                ("<td>" + x.ModelDescription).ToString() + "</td>" +
                ("<td>" + x.OwnerCompanyName).ToString() + "</td>" +
                ("<td>" + x.CompanyCountryCode).ToString() + "</td>" +
                ("<td>" + x.CompanyCountryName).ToString() + "</td>" + 
                "</tr>";
            }
            galutineAtaskaita += "</table></body></html>";
            //File.WriteAllText("htmlReport.html", galutineAtaskaita);

            return galutineAtaskaita;
        }
    }
}
