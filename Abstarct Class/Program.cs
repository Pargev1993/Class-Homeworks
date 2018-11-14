using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            AppleTree appleTree = new AppleTree("Deep", "Long", "Green", 10, 1.2, "Apple", "Golden");

            Spirea spirea = new Spirea("Not so deep", "Not so long", "Green", 15, 0.5, "Beautiful", true, "autom");
            Console.WriteLine("Enter type of tree: Bush or Fetal tree");
                string Type = Console.ReadLine();

            if (Type == "Fetal tree")
            {
                Console.WriteLine(appleTree.PrintAppleTree());
                Console.WriteLine("Apple tree produces Oxygen: " + appleTree.ProducesOxygen());
            }
            else if (Type == "Bush")
            {
                Console.WriteLine(spirea.PrintSpirea());
                Console.WriteLine("Spirea fetal trees produces Oxygen: " + spirea.ProducesOxygen());
            }
            else
                Console.WriteLine("We have not so trees!");

           
            Console.ReadKey();

        }
    }
}
