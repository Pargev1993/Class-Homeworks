using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaesHomework
{
    class Animal : IIntarface, IInterface2 
    {
        public string Name { get; set; }
        public int Energy { get; set; }
        public string  Eat { get; set; }
        public void PrintEat()
        {
            Console.WriteLine($"{Name} eat {Eat}");
        }

        public void Angry()
        {
            if (Energy>50)
                Console.WriteLine($"{Name} Energy coficent is {Energy},thets why Lion is so Angry !");
            else
                Console.WriteLine($"{Name} Energy coficent is { Energy},thets why Lion is so   Low!");
        }

        public void Breathe()
        {
            if (Energy > 50)
                Console.WriteLine($"{Name} Breath is Faster,because he is angry!");
            else
                Console.WriteLine($"{Name} breath is Low, because he is low!");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} Moved with Legs");
        }

        public void Run()
        {
            if (Energy<50)
                Console.WriteLine($"His Energi is {Energy} thets why he run slowly");
           else
                Console.WriteLine($"His Energi is  {Energy}  thets why he run faster");
        }

      public   void  SoundTheSound()
        {
            Console.WriteLine("Mrrrr");
        }

        
        public void Walk()
        {
            Console.WriteLine($"{Name} Mooved With Leg");
        }
    }
}
