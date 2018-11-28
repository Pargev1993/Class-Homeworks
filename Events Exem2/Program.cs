using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Exem2
{
    class ClassCounter
    {
        public delegate void MethodContainer();
        public event MethodContainer Method;

       public void Counter()
        {
            
            for (int i = 0; i < 100; i++)
            {
                if (i == 10)
                    Method();

            }
        }
    }
    class Hendler_1
    {
        public void Message()
        {
            Console.WriteLine("Hurry Up");
        }
    }
    class Hendler_2
    {
        public void Message()
        {
            Console.WriteLine("Hurry Up 71!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassCounter classCounter = new ClassCounter();
            Hendler_1 hendler_1 = new Hendler_1();
            Hendler_2 hendler_2 = new Hendler_2();
            classCounter.Method += hendler_1.Message;
            classCounter.Method += hendler_2.Message;
            classCounter.Counter();
        }
    }
}
