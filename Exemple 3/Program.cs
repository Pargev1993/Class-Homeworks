using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_3
{
    struct Point
    {
        public int X;
        public int Y;
        public Point(int X,int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public  void increment()
        {
            X++;
            Y++;
        }
        public void decrement()
        {
            X--;
            Y--;
        }
        public void display()
        {
            Console.WriteLine("Result X= {0} , Y= {1}", X, Y);
        }
    }

    class Program
    {
        static void ValueTypeAssignment()
        {
            Point P1 = new Point(10, 20);
            Point P2 = P1;
            P1.display();
            P2.display();
            P1.X = 100;
            P2.display();
            P1.display();

        }
        static void Main(string[] args)
        {
            ValueTypeAssignment();
        }
    }
}
