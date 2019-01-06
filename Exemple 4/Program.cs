﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_4
{
    class ShapeInfo
    {
        public string infoString;
        public ShapeInfo(string info)
        {
            infoString = info;
        }
    }
    struct Rectangle
    {
        public ShapeInfo rectInfo;
        public int rectTop, rectLeft, rectBottom, rectRight;
        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            rectInfo = new ShapeInfo(info);
            rectTop = top;
            rectBottom = bottom;
            rectLeft = left;
            rectRight = right;
        }
        public void Display()
        {
            Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " +
            "Left = {3}, Right = {4}",
            rectInfo.infoString, rectTop, rectBottom, rectLeft, rectRight);
        }
    }

    class Program
    {
        static void ValueTypeContainingRefType()
        {
            // Создать первую переменную Rectangle.
            Console.WriteLine("-> Creating r1");
            Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);
            // Присвоить новой переменной Rectangle переменную r1.
            Console.WriteLine("-> Assigning r2 to r1");
            Rectangle r2 = r1;

            // Изменить некоторые значения в r2.
            Console.WriteLine("-> Changing values of r2");
            r2.rectInfo.infoString = "This is new info!";
            r2.rectBottom = 4444;
            // Вывести значения из обеих переменных Rectangle.r1.Display();r2.Display();
            r1.Display();
            r2.Display();
        }
        static void Main(string[] args)
        {
            ValueTypeContainingRefType();
        }
    }
}
