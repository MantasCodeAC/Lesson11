using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson11.Models;

namespace Lesson11.Repositories
{
    internal class AircraftRepository
    {
        private List<Aircraft> Aircrafts = new List<Aircraft>();
        public AircraftRepository()
        {
            Aircrafts.Add(new Aircraft("A900LT", 1, 11));
            Aircrafts.Add(new Aircraft("B901LV", 2, 12));
            Aircrafts.Add(new Aircraft("C902EE", 3, 13));
            Aircrafts.Add(new Aircraft("D903US", 4, 14));
            Aircrafts.Add(new Aircraft("E900UK", 5, 15));
        }

        public Aircraft Retrieve(int iD)
        {
            var talpykla = Aircrafts[0];
            for (int i = 0; i < Aircrafts.Count; i++)
            {
                if (Aircrafts[i].ID == iD)
                {
                    talpykla = Aircrafts[i];
                }
            }
            return talpykla;
        }
        public List<Aircraft> Retrieve()
        {
            return Aircrafts;
        }

    }
}
