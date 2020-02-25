using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter6
{
    class Building
    {
        private string DesignerName { get; set; }

        private DateTime DateConstructed { get; set; }

        private string BuildingAddress { get; set; }

        private string BuildingOwner { get; set; }

        //public properties
        //Stories typed as an integer.
        //Width typed as a double.
        //Depth typed as a double.
        //Volume should be read-only and should return width* depth * (3 * # of stories). Each story is 3 meters high.


        public int NumberOfStories { get; set; }

        public double Width { get; set; }
        public double Depth { get; set; }

        public double Volume
        {
            get

            {
                return Width * Depth * (3 * NumberOfStories);
            }
        }


        public Building(string address, string designer)
        {
            BuildingAddress = address;
            DesignerName = designer;
        }

        public Address name { get; set; }

        public void Construct()
        {
            DateConstructed = DateTime.Now;
        }

        public void Purchase(string buyer)
        {
            BuildingOwner = buyer;
        }

        public void DisplayBuildingInfo()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine(this.BuildingAddress);
            Console.WriteLine("Designed By: " + DesignerName);
            Console.WriteLine("Date Constructed: " + DateConstructed);
            Console.WriteLine("Owned By: " + BuildingOwner);
            Console.WriteLine(Volume + " cubic meters of space");
            Console.WriteLine("--------------------");
        }

    }
}
