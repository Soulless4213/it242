using System;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is where you make objects based on the class blueprint
            Building MCTC = new Building("1 Moutwest Way", "Satoshi Nakamoto")
            {
                Width = 100,
                Depth = 200,
                NumberOfStories = 4
            };
            Building CapitalBuilding = new Building("412 8th Street", "Art Deckko")
            {
                Width = 1000,
                Depth = 250,
                NumberOfStories = 8
            };
            Building MyHouse = new Building("1540 Way of Hollering", "Me")
            {
                Width = 10,
                Depth = 50,
                NumberOfStories = 2
            };

            //Construct each building.
            MCTC.Construct();
            CapitalBuilding.Construct();
            MyHouse.Construct();
            MCTC.Purchase("Martin");
            CapitalBuilding.Purchase("John Doe");
            MyHouse.Purchase("Dillon Vance");

            MCTC.DisplayBuildingInfo();
            CapitalBuilding.DisplayBuildingInfo();
            MyHouse.DisplayBuildingInfo();






            Console.WriteLine("");
        }
    }
}
