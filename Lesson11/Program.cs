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

