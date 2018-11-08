using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Person = new Human("Pargev", "Avagyan", 25, 60, "Boy");
            String Me = Person.PrintAll();
            Console.WriteLine(Me);
            Console.ReadKey();
        }
    }
}
