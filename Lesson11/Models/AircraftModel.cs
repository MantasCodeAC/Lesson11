using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Models
{
    internal class AircraftModel
    {
        public int ModelNumber { get; set; }
        public string ModelDescription { get; set; }
        public int ID { get; set; }
        public AircraftModel(int modelNumber, string modelDescription, int iD)
        {
            ModelNumber = modelNumber;
            ModelDescription = modelDescription;
            ID = iD;
        }
    }
}
