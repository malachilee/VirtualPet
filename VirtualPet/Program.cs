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
            Virtual_Pet pet = new Virtual_Pet();
            

            Random random = new Random();
            int initAge = random.Next(1, 5);
            int initHunger = random.Next(60, 75);
            int initThirst = random.Next(75, 85);
            int initSleep = random.Next(60, 70);

            pet.Age = initAge;
            pet.Hunger = initHunger;
            pet.Thrist = initThirst;
            pet.Sleep = initSleep;

            Console.WriteLine("Welcome to the VirtualPet");
            Console.WriteLine();
            Console.WriteLine("Please type Yes to start the game");
            string userResponse = Console.ReadLine().ToLower();
           
                Console.WriteLine("Type your new pets name bellow!");
                pet.Name = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Your new pet {0} is ready to meet you!", pet.Name);
                Console.WriteLine("Age of your pet: {0}", pet.Age);
                Console.WriteLine("Your pets Hunger Level: {0}", pet.Hunger);
                Console.WriteLine("Your pets Thirst: {0}", pet.Thrist);
                Console.WriteLine("Your pets sleep level: {0}", pet.Sleep);
                Console.WriteLine();
                Console.WriteLine();
            while (userResponse.Equals("yes"))
            {
                Console.WriteLine("Please select from the following to take care of {0}", pet.Name);
                Console.WriteLine();
                Console.WriteLine("Type 1 to feed {0}.", pet.Name);
                Console.WriteLine();
                Console.WriteLine("Type 2 to give {0} some water.", pet.Name);
                Console.WriteLine();
                Console.WriteLine("Type 3 to let {0} sleep", pet.Name);
                Console.WriteLine();
                int menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        { pet.Feed(); }
                        break;

                    case 2:
                        { pet.GiveWater(); }
                        break;

                    case 3:
                        { pet.Rest(); }
                        break;


                }


            }
        }
    }
}
