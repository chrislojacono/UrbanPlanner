using System;
using System.Collections.Generic;
using System.Text;

namespace UrbanPlanner
{
    class Building
    {
        //Private Fields
        private string _designer = "Chris LoJacono";
        private DateTime _dateConstructed = DateTime.Now;
        private string _address = "510 old hickory blvd, Nashville, TN, 37209";
        private string _owner = "Bill Hamlend";

        public int Stories { get; set; } = 3;
        public double Width { get; set; } = 44.3;
        public double Height { get; set; } = 55.4;
        public double Volume
        {
            get => Width * Height * (3 * Stories);
        }
        public Building(string address)
        {
            _address = address;
        }
        public DateTime Construct()
        {
            _dateConstructed = DateTime.Now;
            return _dateConstructed;
        }
        public string Purchase(string newOwner)
        {
            _owner = newOwner;
            return _owner;
        }
        public string Designer() => _designer;
        public string Address() => _address;
        public string Owner() => _owner;

    }
}
