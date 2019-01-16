using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Del(int x, int y)
        {
            try
            {
                int result = x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль!");
                throw;
            }
        }

        static void Main()
        {
            try
            {
                Del(5, 0);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Программная ошибка!");
            }

            Console.ReadLine();
        }
    }
}