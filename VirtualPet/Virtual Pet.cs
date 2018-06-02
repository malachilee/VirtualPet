using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Virtual_Pet
    {
     // Declare Fields

        private int age;
        private int hunger;
        private int thrist;
        private string name;

     // Declare Properties

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Thrist
        {
            get { return this.thrist; }
            set { this.thrist = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

     // Declare Constructors

        public Virtual_Pet()
        {
         // Default Constructor
        }

        public Virtual_Pet(int age, int hunger, int thrist, string name)
        {
            this.Age = age;
            this.Hunger = hunger;
            this.Name = name;
        }

     // Declare Methods

        public void Tick()
        {
            Age++;
            if(Age > 20)
            {
                Console.WriteLine("Your pet died from old age.");
            }

            Hunger += 12;
            if(Hunger < 0)
            {
                Console.WriteLine("Your pet died from starvation.");
            }
       
        }

        public void Feed()
            {
            this.Hunger -= 30;
            this.Thrist += 20;
            Console.WriteLine("{0} says thanks, that tasted great!", this.Name);
            }

        public void GiveWater()
        {
            this.Thrist -= 50;
        }

            










    }
}
