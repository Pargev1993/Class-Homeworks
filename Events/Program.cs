using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        public delegate double ResultOfNumbers(double x, double y);

        class Calculator
        {
            public event ResultOfNumbers NumbersOf;
            public void EventInvoke()
            {
                NumbersOf(15, 20);
            }
        }

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.NumbersOf += Add;
            calculator.NumbersOf += Sum;
            calculator.NumbersOf += Mult;
            calculator.NumbersOf += Divis;
            calculator.NumbersOf += SmallistOddNumber;
            calculator.EventInvoke();


        }
        public static double Add(double x, double y)
        {
            double res = x + y;
            Console.WriteLine(res);
            return res;
        }
        public static double Sum(double x, double y)
        {
            double res = ++x - y--;
            Console.WriteLine(res);
            return res;

        }
        public static double Mult(double x, double y)
        {
            double res = x * y;
            Console.WriteLine(res);
            return res;

        }
        public static double Divis(double x, double y)
        {
            if (y != 0)
            {
                double res = x / y;
                Console.WriteLine(res);
                return res;
            }
            else
                return 0;
        }
        public static double SmallistOddNumber (double x,double y)
        {
            int i;
            for (i = 1; i < x; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    return i;
                    break;
                }
                
                
            }
            return i;
        }
      

    }
}
