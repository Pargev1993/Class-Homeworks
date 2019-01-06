using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.codingschool.OOP.Struct
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
        public void Increment()
        {
            X++;
            Y++;
        }
        public void Decrement()
        {
            X--;
            Y--;
        }
        public void Display()
        {
            Console.WriteLine("Result X= {0} , Y= {1}", X, Y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point MyPoint=new Point (50,60);
            MyPoint.Display();
            MyPoint.Increment();
            MyPoint.Display();
            MyPoint.Decrement();
            MyPoint.Display();


        }
    }
}
