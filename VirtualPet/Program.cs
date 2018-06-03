using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Virtual_Pet pablo = new Virtual_Pet();
            pablo.Tick();

            Random random = new Random();
            int initAge = random.Next(1, 5);
            int initHunger = random.Next(60, 75);
            int initThirst = random.Next(75, 85);
            int initSleep = random.Next(60, 70);

            pablo.Age = initAge;
            pablo.Hunger = initHunger;
            pablo.Thrist = initThirst;
            pablo.Sleep = initSleep;


            /* Test:*/
            Console.WriteLine(" " + pablo.Age + " " + pablo.Hunger + " " + pablo.Thrist + " " + pablo.Sleep + " " + pablo.Name );
        }
    }
}
