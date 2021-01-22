using System;


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


    }
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Width = 150.4,
                Height = 133.2,
                Stories = 5,

            };
            Building myApartment = new Building("510 Old hickory blvd")
            {
                Width = 230.4,
                Height = 183.2,
                Stories = 3,

            };
            Building momsHouse = new Building("2001 boxwood drive")
            {
                Width = 450.4,
                Height = 173.2,
                Stories = 1,
            };
            Console.WriteLine($"{FiveOneTwoEigth.Address()}-------------");
            Console.WriteLine($"Designed by {FiveOneTwoEigth.Designer()}");
            Console.WriteLine($"COnstruced on {FiveOneTwoEigth.Construct()}");
            Console.WriteLine($"Owned by {FiveOneTwoEigth.Purchase("Bob Ross")}");
            Console.WriteLine($"{FiveOneTwoEigth.Volume} cubic meters of space");
        }
    }
}
