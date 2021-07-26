using System;
using System.ComponentModel.DataAnnotations;

namespace elevators
{
    public class Elevator
    {
        public int destination {get; set;}
        public int currentLocation {get; set;}

        public Elevator() {   
           currentLocation = 0;   
           destination = 0;     
        }
        public void moveElevator(int destination, Elevator e) {
            if (destination == 10) {
                Console.WriteLine("This elevator does not go to the penthouse. Take elevator B");
                return;
            }
            else if (destination > 10 || destination < -1) {
                Console.WriteLine("Invalid location");
                return;
            }

            Console.WriteLine("You ll arrive in " + (Math.Abs(e.currentLocation - destination))+ " seconds");
            e.currentLocation = destination; 
            Console.WriteLine("You are now at " + destination + " floor");
        }
    }
}
