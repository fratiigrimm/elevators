using System;

namespace elevators
{
    public class Building
    {
        public string name {get; set;}
        public int noOfFloors {get; set;}
        public int noOfElevators {get; set;}

        public Building() {
            name = "Trump Tower One";
            noOfFloors = 11;
            noOfElevators = 2;
        }
        public void chooseElevator() {
            Console.WriteLine("Choose your elevator: A or B");
        }

        public void invalidOption () {
                Console.WriteLine("This elevator does not exist !!!");
                Environment.Exit(0);
        }

    }
}
