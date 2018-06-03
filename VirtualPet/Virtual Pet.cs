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
            this.Hunger += 6;
            this.Thrist += 6;
            this.Sleep += 8;
            if(this.Age > 20)
              {
                Console.WriteLine("{0} died from old age.", this.Name);
              }
           
            if(this.Hunger >= 100)
              {
                Console.WriteLine("{0} died from starvation.", this.Name);
              }
            
            if(this.Thrist >= 100)
              {
                Console.WriteLine("{0} died from dehydration.", this.Name);
              }
            
            if(this.Sleep >= 100)
              {
                Console.WriteLine("{0} died from sleep deprivation.", this.Name);
              }
        }

        public void Feed()
        {
            this.Tick();
            this.Hunger -= 40;
            this.Thrist += 10;
            Console.WriteLine("{0} says thanks, that tasted great!", this.Name);
            Console.WriteLine();
            Console.WriteLine("{0}s age now is: {1}", this.Name, this.Age);
            Console.WriteLine("{0}s Hunger level now is: {1}", this.Name, this.Hunger);
            Console.WriteLine("{0}s Thirst level now is: {1}", this.Name, this.Thrist);
            Console.WriteLine("{0}s Sleep level now is: {1}", this.Name, this.Sleep);

        }

        public void GiveWater()
        {
            this.Tick();
            this.Thrist -= 50;
            Console.WriteLine("{0} says that was refreshing!", this.Name);
            Console.WriteLine();
            Console.WriteLine("{0}s age now is: {1}", this.Name, this.Age);
            Console.WriteLine("{0}s Hunger level now is: {1}", this.Name, this.Hunger);
            Console.WriteLine("{0}s Thirst level now: {1}", this.Name, this.Thrist);
            Console.WriteLine("{0}s Sleep level now is: {1}", this.Name, this.Sleep);
        }

        public void Rest()
        {
            this.Tick();
            this.Sleep -= 50;
            this.Hunger += 20;
            this.Thrist += 20;
            Console.WriteLine("{0} is well rested", this.Name);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0}s age now is: {1}", this.Name, this.Age);
            Console.WriteLine("{0}s Hunger level now is: {1}", this.Name, this.Hunger);
            Console.WriteLine("{0}s Thirst level now: {1}", this.Name, this.Thrist);
            Console.WriteLine("{0}s Sleep level now is: {1}", this.Name, this.Sleep);
        } 

            










    }
}
