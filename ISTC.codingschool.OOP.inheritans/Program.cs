using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.codingschool.OOP.inheritans
{
    class Person
    {
        public string Name { get; set; }
        private int Age;
        public Person(int age,string name)
        {
            Name = name;
            Age = age;
        }
    }
    class Director:Person
    {
        
        public int Price { get; set; }
        private double Hige;
        public Director(double hige,string name,int age,int price):base(age,name)
        {
            Price = price;
        }

    }
    class worker:Person
    {
        public string Vakanci { get; set; }
        public worker(string name,int age,string vakanci):base(age,name)
        {
            Vakanci = vakanci;
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director(25, "Armen", 26, 100000);
            Console.WriteLine(director);
        }
    }
}
