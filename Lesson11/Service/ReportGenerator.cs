using Lesson11.Models;
using Lesson11.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Service
{
    internal class ReportGenerator
    {
        public AircraftRepository _aircraftRepository { get; set; }
        public AircraftModelRepository _aircraftModelRepository { get; set; }
        public CompanyRepository _companyRepository { get; set; }
        public CountryRepository _countryRepository { get; set; }
        public ReportGenerator(AircraftRepository aircraftRepository, AircraftModelRepository aircraftModelRepository,
            CompanyRepository companyRepository, CountryRepository countryRepository)
        {
            _aircraftRepository = aircraftRepository;
            _aircraftModelRepository = aircraftModelRepository;
            _companyRepository = companyRepository;
            _countryRepository = countryRepository;
        }

        public List<ReportItem> GenerateReportAircraftInEurope()
        {
            List<string> countriesOfEU = new List<string>()
            {
                    "Austria", "Belgium", "Bulgaria", "Croatia", "Czech Republic", "Hungary", 
                    "Denmark", "Estonia", "Finland", "France", "Germany", "Greece", "Ireland", 
                    "Italy", "Latvia", "Lithuania", "Luxembourg", "Malta", "Netherlands", "Poland",
                    "Romania",  "Slovakia",  "Slovenia",  "Spain", "Sweden", "Portugal"
            };
            var listNotEUAircraft = new List<Aircraft>();
            var listEUAircraft = new List<Aircraft>();
            var listAircraft = _aircraftRepository.Retrieve();
            foreach(var planes in listAircraft)
            {
                var y = _countryRepository.Retrieve(_companyRepository.Retrieve(planes.CompanyID).CountryId);
                if (y.InEurope)
                {
                    listEUAircraft.Add(planes);
                }
            }
            /*
                var listCompanyID = listAircraft.Select(aircraft => aircraft.CompanyID).ToList();

            foreach (var companyID in listCompanyID)
            {
                listEUAircraft.Add(_aircraftRepository.Retrieve(companyID));
                var x = _companyRepository.Retrieve(companyID).CountryId;
                Console.WriteLine(_companyRepository.Retrieve(_companyRepository.Retrieve(companyID).CountryId));

            }
            */
            List <ReportItem> reportItems = new List<ReportItem>();
            foreach (var aircrafts in listEUAircraft)
            {
                ReportItem reportItem = new ReportItem();
                reportItem.TailNumber = aircrafts.TailNumber;
                reportItem.ModelNumber = (_aircraftModelRepository.Retrieve(aircrafts.ID)).ModelNumber;
                reportItem.ModelDescription = (_aircraftModelRepository.Retrieve(aircrafts.ID)).ModelDescription;
                reportItem.OwnerCompanyName = (_companyRepository.Retrieve(aircrafts.CompanyID)).OwnerCompanyName;
                reportItem.CompanyCountryCode = _countryRepository.Retrieve(_companyRepository.Retrieve(aircrafts.CompanyID).CountryId).CompanyCountryCode;
                reportItem.CompanyCountryName = _countryRepository.Retrieve(_companyRepository.Retrieve(aircrafts.CompanyID).CountryId).CompanyCountryName;
                reportItems.Add(reportItem);
                if (countriesOfEU.Contains(reportItem.CompanyCountryName)) 
                {
                    reportItem.InEuropeUnion =  $"{reportItem.CompanyCountryName} is in European Union. Blue";
                }

                else
                {
                    reportItem.InEuropeUnion = $"{reportItem.CompanyCountryName} is not in European Union. Red";
                }
            }
            return reportItems;
        }

        public List<ReportItem> GenerateReportAircraftNotInEurope()
        {   
        var listNotEUAircraft = new List<Aircraft>();
        var listAircraft = _aircraftRepository.Retrieve();

        foreach (var planes in listAircraft)
        {
            var y = _countryRepository.Retrieve(_companyRepository.Retrieve(planes.CompanyID).CountryId);
            if (y.InEurope == false)
            {
                listNotEUAircraft.Add(planes);
            }
        }
        List<ReportItem> reportItems = new List<ReportItem>();
        foreach (var aircrafts in listNotEUAircraft)
        {
            ReportItem reportItem = new ReportItem();
            reportItem.TailNumber = aircrafts.TailNumber;
            reportItem.ModelNumber = (_aircraftModelRepository.Retrieve(aircrafts.ID)).ModelNumber;
            reportItem.ModelDescription = (_aircraftModelRepository.Retrieve(aircrafts.ID)).ModelDescription;
            reportItem.OwnerCompanyName = (_companyRepository.Retrieve(aircrafts.CompanyID)).OwnerCompanyName;
            reportItem.CompanyCountryCode = _countryRepository.Retrieve(_companyRepository.Retrieve(aircrafts.CompanyID).CountryId).CompanyCountryCode;
            reportItem.CompanyCountryName = _countryRepository.Retrieve(_companyRepository.Retrieve(aircrafts.CompanyID).CountryId).CompanyCountryName;
            reportItems.Add(reportItem);
        }

        return reportItems;
    }



        

    }
}
