using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Models
{
    internal class Aircraft
    {
        public string TailNumber { get; set; }
        public int ID { get; set; }
        public int CompanyID { get; set; }
        public Aircraft(string tailNumber, int iD, int companyID)
        {
            TailNumber = tailNumber;
            ID = iD;
            CompanyID = companyID;
        }

    }
}
