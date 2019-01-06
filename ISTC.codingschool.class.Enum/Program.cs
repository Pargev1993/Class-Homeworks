using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumer
{
    enum Enumtype:byte
    {
        manager,
        worker,
        director,
    }

    class Program
    {
        static void Main(string[] args)
        {
            Enumtype @enum = Enumtype.manager;
            AskforBonus(@enum);
            Console.WriteLine(Enum.GetUnderlyingType(@enum.GetType()));
        }
        static void AskforBonus(Enumtype e)
        {
            switch (e)
            {
                case Enumtype.director:
                    Console.WriteLine("Director");
                    break;
                case Enumtype.manager:
                    Console.WriteLine("Manager");
                    break;

            }
        }
    }
}

