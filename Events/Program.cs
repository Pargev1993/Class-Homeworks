﻿using System;
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
            public void EventInvoke(double x, double y)
            {
                NumbersOf.Invoke(x, y);
            }
            public double Numbers(out double x, out double y)
            {
                while (true)
                {


                    try
                    {
                        Console.WriteLine("Enter X number");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Y number");
                        y = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please Enter Number!");
                        continue;
                    }
                }
                return y;

            }

            //public double XNumber(double x)
            //{
            //        try
            //        {
            //            Console.WriteLine("Enter X number");
            //            x = double.Parse(Console.ReadLine());

            //        }
            //        catch (FormatException)
            //        {
            //            Console.WriteLine("Please Enter Number!");
            //        XNumber(x);
            //        }
                
            //    return x;

            //}

            static void Main(string[] args)
            {
                Calculator calculator = new Calculator();
                calculator.Numbers(out double x, out double y);
                Console.WriteLine("Please Chose An Operation wich one you wont to do: +,-,*,/ ");
                string Oper = Console.ReadLine();
                switch (Oper)
                {

                    case "-":
                        calculator.NumbersOf += Sum;
                        calculator.EventInvoke(x, y);
                        break;
                    case "*":
                        calculator.NumbersOf += Mult;
                        calculator.EventInvoke(x, y);
                        break;
                    case "/":
                        calculator.NumbersOf += Divis;
                        calculator.EventInvoke(x, y);
                        break;
                    case "+":
                        calculator.NumbersOf += Add;
                        calculator.EventInvoke(x, y);
                        break;

                }
            }
            public static double Add(double x, double y)
            {
                double res = x + y;
                Console.WriteLine("Result of Operation: " + res);
                return res;
            }
            public static double Sum(double x, double y)
            {
                double res = x - y;
                Console.WriteLine("Result of Operation: " + res);
                return res;

            }
            public static double Mult(double x, double y)
            {
                double res = x * y;
                Console.WriteLine("Result of Operation: " + res);
                return res;

            }
            public static double Divis(double x, double y)
            {
                if (y != 0)
                {
                    double res = x / y;
                    Console.WriteLine("Result of Operation: " + res);
                    return res;
                }
                else
                    return 0;
            }
            //public static double SmallistOddNumber(double x, double y)
            //{
            //    int i;
            //    for (i = 1; i < x; i++)
            //    {
            //        if (i % 3 == 0)
            //        {
            //            Console.WriteLine(i);
            //            return i;
            //            break;
            //        }


            //    }
            //    return i;
            //}
           

        }
    }
}
