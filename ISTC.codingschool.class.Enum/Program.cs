using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    enum Enum
    {
        manager,
        worker,
        director,
    }

    class Program
    {
        static void Main(string[] args)
        {
            Enum @enum = Enum.manager;
            AskforBonus(@enum);
        }
        static void AskforBonus(Enum e)
        {
            switch (e)
            {
                case Enum.director:
                    Console.WriteLine("Director");
                    break;
                case Enum.manager:
                    Console.WriteLine("Manager");
                    break;

            }
        }
    }
}

