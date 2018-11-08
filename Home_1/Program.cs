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
            This This = new This("Pargev", "Avagyan", 25, 60, "Boy");
            String Me = This.PrintAll();
            Console.WriteLine(Me);
            Console.ReadKey();
        }
    }
}
