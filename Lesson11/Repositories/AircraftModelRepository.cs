using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson11.Models;

namespace Lesson11.Repositories
{
    internal class AircraftModelRepository
    {
        private List<AircraftModel> AircraftsModels = new List<AircraftModel>();
        public AircraftModelRepository()
        {
            AircraftsModels.Add(new AircraftModel(900, "Small", 1));
            AircraftsModels.Add(new AircraftModel(901, "Big", 2));
            AircraftsModels.Add(new AircraftModel(902, "Medium", 3));
            AircraftsModels.Add(new AircraftModel(903, "Huge", 4));
            AircraftsModels.Add(new AircraftModel(904, "Small", 5));
        }

        public AircraftModel Retrieve(int aircraftId)
        {
            var talpykla = AircraftsModels[0];
            for (int i = 0; i < AircraftsModels.Count; i++)
            {
                if (AircraftsModels[i].ID == aircraftId)
                {
                    talpykla = AircraftsModels[i];
                }
            }
            return talpykla;
        }
        public List<AircraftModel> Retrieve()
        {
            return AircraftsModels;
        }

    }
}
