using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValyuRef
{
    class Person
    {
        public string Name;
        public int Age;
    }
    class Program
    {
        static void Change( ref Person person)
        {

            person.Name = "Jon";
            person = new Person();
            person.Name = "Jemy";
            person.Age = 36;            
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 25;
            person.Name = "Bill";
            Change(ref person);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Name);
        }
    }
}
