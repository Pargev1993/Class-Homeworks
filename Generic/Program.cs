using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Derivedclass Instance = new Derivedclass();
            Instance.Fild1 = "1";
            Instance.Fild2 = "20";
            Instance.Fild3 = "3";
            Instance.Fild4 = "4";
            Instance.Fild5 = "5";

            Baseclass newinstance = Instance;
            Console.WriteLine(newinstance.Fild1);
            Console.WriteLine(newinstance.Fild2);
            Console.WriteLine(newinstance.Fild3);
            // Console.WriteLine(newinstance.Fild4);
            //Console.WriteLine(newinstance.Fild5);
            Console.ReadKey();

        }
    }
}
