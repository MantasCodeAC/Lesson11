// See https://aka.ms/new-console-template for more information
using Lesson11.Models;
using Lesson11.Repositories;
using Lesson11.Service;
using System.Numerics;


AircraftRepository aircraftRepository = new AircraftRepository();
AircraftModelRepository aircraftModelRepository = new AircraftModelRepository();
CompanyRepository companyRepository = new CompanyRepository();
CountryRepository countryRepository = new CountryRepository();

ReportGenerator reportGenerator = new ReportGenerator(aircraftRepository, aircraftModelRepository,
    companyRepository, countryRepository);

var x = reportGenerator.GenerateReportAircraftInEurope();
var y = reportGenerator.GenerateReportAircraftNotInEurope();

HTMLGenerator htmlGenerator = new HTMLGenerator();
Console.WriteLine("The Aircrafts registred in Europe\n________________________________\n" 
    + htmlGenerator.GenerateHTMLWithColor(x));
Console.WriteLine("The Aircrafts registred NOT in Europe\n________________________________\n" 
    + htmlGenerator.GenerateHTMLWithColor(y));





/*var reportItems = (reportGenerator.GenerateReportAircraftInEurope());
foreach (var x in reportItems)
{
    Console.WriteLine("Aircraft Tail Number: " + x.TailNumber);
    Console.WriteLine("Aircraft Model Number: " + x.ModelNumber);
    Console.WriteLine("Aircraft Model Description: " + x.ModelDescription);
    Console.WriteLine("Owner Company Name: " + x.OwnerCompanyName);
    Console.WriteLine("Company Country Code: " + x.CompanyCountryCode);
    Console.WriteLine("Company Country Name: " + x.CompanyCountryName);
    Console.WriteLine("-----------------------------------------------");
}
*/

