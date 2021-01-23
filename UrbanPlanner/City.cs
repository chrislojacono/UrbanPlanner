using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner
{
    class City
    {
        public string Name { get; set; }
        public string Mayor { get; set; }
        public List<Building> Buildings { get; set; } = new List<Building>();

        private int _yearEstablished = 2021;

        public void AddBuilding (Building building)
        {
            Buildings.Add(building);
        }
        public int showYear() => _yearEstablished;

    }
}
