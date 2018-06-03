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
        private int sleep;
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

        public int Sleep
        {
            get { return this.sleep; }
            set { this.sleep = value; }
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

        public Virtual_Pet(int age, int hunger, int thrist, int sleep, string name)
        {
            this.Age = age;
            this.Hunger = hunger;
            this.Thrist = thrist;
            this.Sleep = sleep;
            this.Name = name;
        }

     // Declare Methods

        public void Tick()// Tick Method
        {
            this.Age++;
            if(Age > 20)
              {
                Console.WriteLine("{0} died from old age.", this.Name);
              }
            this.Hunger += 6;
            if(Hunger == 100)
              {
                Console.WriteLine("{0} died from starvation.", this.Name);
              }
            this.Thrist += 10;
            if(Thrist == 100)
              {
                Console.WriteLine("{0} died from dehydration.", this.Name);
              }
            this.Sleep += 8;
            if(Sleep == 100)
              {
                Console.WriteLine("{0} died from sleep deprivation.", this.Name);
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
            Console.WriteLine("{0} says that was refreshing!", this.Name);
        }

        public void Rest()
        {
            this.Sleep -= 50;
            Console.WriteLine("{0} is well rested", this.Name);
        } 

            










    }
}
