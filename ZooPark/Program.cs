using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish("Ishxan", 25, "kkjk", "yes", "hjh", 10.32);
            Animals[] animals = new Animals[2];
            Shark shark = new Shark(56,"yes","yes","White Acula",120,"yes");
            animals[0] =(Animals) fish;
            Fish fish1 = (Fish)animals[0];
            animals[1] = shark;
            animals[0].Eat();
            shark.Eat();
            Cow cow = new Cow("Muuu", 20, "", "4", "Cow", 78, "Grass", "yes");
            Console.ReadKey();
        }
    }
}
