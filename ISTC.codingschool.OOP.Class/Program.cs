using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.codingschool.OOP.Class
{
    class Persone
    {
        public int Age;
        public string Name;
        public Persone( int Age,string Name)
        {
            this.Age = Age;
            this.Name = Name;
        }
        public Persone() { }
        public void Display()
        {
            Console.WriteLine("Name {0} : Age {1} ",Name,Age);
        }
        
       
    }
    class Program
    {
         static void SendAPersonByValue(Persone P)
        {
            P.Age = 99;
            P = new Persone(25, "Nikki");
        }
        static void Main(string[] args)
        {
            Persone persone = new Persone
            {
                Age = 25,
                Name = "Bob"
            };
            persone.Display();
            SendAPersonByValue(persone);
            persone.Display();

        }
    }
}
