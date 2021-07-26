using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace elevators
{
    class Program
    {
        static void Main(string[] args)
        {
            Building b = new Building();
            var people = new List<Passanger>(); // list of passangers
            var floors = new List<Floor>();  // list of building floors

            for (int i = 0; i < 10; i++){
                 people.Add(new Passanger { pName = "Person #" + (i + 1) });
            }
            for (int i = 0; i < 12; i++){
                 floors.Add(new Floor { num = i - 1} );
            }

            Hashtable h = new Hashtable();
            h.Add(people[0].pName, floors[3].num);
            h.Add(people[1].pName, floors[0].num);
            h.Add(people[2].pName, floors[5].num);
            h.Add(people[3].pName, floors[10].num);
            h.Add(people[4].pName, floors[5].num);
            h.Add(people[5].pName, floors[7].num);
            h.Add(people[6].pName, floors[4].num);
            h.Add(people[7].pName, floors[3].num);
            h.Add(people[8].pName, floors[3].num);
            h.Add(people[9].pName, floors[11].num);

            Elevator A = new Elevator();
            Elevator B = new Elevator();

            Console.WriteLine("Welcome to " + b.name); 
            Console.WriteLine("--------------------");
            // show location of each passanger
            // for (int i = 0; i < 10; i++){
            //      Console.WriteLine(people[i].pName + " in on the " + h[people[i].pName] + " floor");
            // }
            
        while(true) {
            string elevatorOption = null;
            b.chooseElevator();
            elevatorOption = Console.ReadLine();
            if (elevatorOption != "A" && elevatorOption != "B") {
                b.invalidOption();
            }
            var random = new Random();
            int index = random.Next(people.Count);
            Console.WriteLine(people[index].pName + " calls the elevator " + elevatorOption + " from " + (h[people[0].pName]) + " floor");
            if (elevatorOption == "A") {
                Console.WriteLine("Elevator " + elevatorOption + " will arrive in " + 
                (Convert.ToInt32(h[people[index].pName]) - A.currentLocation) + " seconds");
                Console.WriteLine("Choose destination floor: ");
                int destination = 0;
                destination = Convert.ToInt32(Console.ReadLine());
                A.moveElevator(destination, A);

            }
            else if (elevatorOption == "B") {
                Console.WriteLine("Elevator " + elevatorOption + " will arrive in " + 
                (Convert.ToInt32(h[people[0].pName]) - B.currentLocation) + " seconds");
            }
            else {
                Console.WriteLine("SYSTEM ERROR");
                return;
            }
            }
        }
    }
}
