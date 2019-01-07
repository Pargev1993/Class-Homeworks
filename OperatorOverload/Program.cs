using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OperatorOverload;

namespace OperatorOverload
{
    class Counter
    {
        public int Value { get; set; }

        public static bool operator <(Counter c1, Counter c2)
        {
            return c1.Value < c2.Value;
        }
        public static bool operator >(Counter c1, Counter c2)
        {
            return c1.Value > c2.Value;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter { Value = 25 };
            Counter c2 = new Counter { Value = 33 };
            bool res = c1 < c2;
            Console.WriteLine(res);

        }
    }
}
