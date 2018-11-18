using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaesHomework
{
    class Human:IInterface2,IInterface3
    {
        public string Eat { get; set; }
        public string Name { get; set; }
        public int IQ { get; set; }
        public int Leg { get; set; }
         public void PrintEat()
        {
            Console.WriteLine($"{Name} Eat {Eat} ");
        }
        public Human(int iq,string name,int leg)
        {
            IQ = iq;
            Name = name;
            Leg = leg;
        }
      
        public void PrintName()
        {
            Console.WriteLine($"My Name is {Name}");
        }
        public void Think()
        {
            if (IQ<100)
            Console.WriteLine($"{Name}  thinq with nothing, beqouse his IQ is  {IQ}");
            else
                Console.WriteLine($"{Name}  thinq with brain");
        }

        public void Run()
        {
            if (Leg==2)
            Console.WriteLine("He Run With Leg");
            else
                Console.WriteLine("He cant Run");
        }

        public void Breathe()
        {
            Console.WriteLine("lungs");
        }

        public void Angry()
        {

                Console.WriteLine($"{Name} is  Low!");
        }
    }
}
