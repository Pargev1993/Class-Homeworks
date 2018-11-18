using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("carnivorous");
            cat1.Name = "Lion";
            Console.WriteLine($"Enter {cat1.Name} Energy");
            int Energy = int.Parse(Console.ReadLine());
            cat1.Energy = Energy;
            cat1.Breathe();
            cat1.Run();
            cat1.Angry();
            cat1.Move();
            cat1.Eat = "meat";
            cat1.PrintEat();

            Console.WriteLine(new string('-', 25));

            Cat cat2 = new Cat( "carnivorous");
            cat2.Name = "Tiger";
            Console.WriteLine($"Enter {cat2.Name} Energy");
             Energy = int.Parse(Console.ReadLine());
            cat2.Energy = Energy;
            cat2.Move();
            cat2.SoundTheSound();
            cat2.Breathe();
            cat2.Angry();
            cat2.Eat = "meat";
            cat2.PrintEat();


            Console.WriteLine(new string ('-',25));

            Console.WriteLine("Enter Yore leg Quantity");
            int leg = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your IQ");
            int IQ = int.Parse(Console.ReadLine());
            Human human = new Human(IQ,"Pargev",leg);
            human.PrintName();
            human.Run();
            human.Think();
            human.Angry();
            human.Eat = "Eco Food";
            human.PrintEat();

            Console.WriteLine(new string('-', 25));
            Animal Cow = new Animal();
            Cow.Name = "Wite Cow ";
            Console.WriteLine($"Enter {Cow.Name} Energy");
             Energy = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Yore leg Quantity");
             leg = int.Parse(Console.ReadLine());
            Cow.Energy = Energy;
            Cow.Eat = "Grass";
            Cow.PrintEat();
            Cow.Angry();
            Cow.Move();
            Cow.Run();


          
        }
    }
}
