using System;


namespace UrbanPlanner
{
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

            // Console.WriteLine($"{FiveOneTwoEigth.Address()}-------------\nDesigned by {FiveOneTwoEigth.Designer()}\nConstruced on {FiveOneTwoEigth.Construct()}\nOwned by {FiveOneTwoEigth.Purchase("Bob Ross")}\n{FiveOneTwoEigth.Volume} cubic meters of space");

            // Console.WriteLine($"{momsHouse.Address()}-------------\nDesigned by {momsHouse.Designer()}\nConstruced on {momsHouse.Construct()}\nOwned by {momsHouse.Purchase("Laura LoJacono")}\n{momsHouse.Volume} cubic meters of space");
            FiveOneTwoEigth.Purchase("Bob Ross");
            myApartment.Purchase("Amy Sedaris");
            momsHouse.Purchase("Brock Lesner");
            City megalopolis = new City()
            {
                Name = "Megalopolis",
                Mayor = "Doug Dimmadome",
            };
            megalopolis.AddBuilding(FiveOneTwoEigth);
            megalopolis.AddBuilding(myApartment);
            megalopolis.AddBuilding(momsHouse);

            foreach (Building building in megalopolis.Buildings)
            {
                Console.WriteLine($"{building.Address()}-------------\nDesigned by {building.Designer()}\nConstruced on {building.Construct()}\nOwned by {building.Owner()}\n{building.Volume} cubic meters of space");
                Console.WriteLine("");
            }
        }
    }
}
