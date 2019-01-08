using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ISTC.codingschool.OOP.WorkWithFiles1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"c:\";
            string[] directory = Directory.GetDirectories(str);
            foreach (var item in directory)
            {


                try
                {
                    string[] dir = Directory.GetDirectories(item);
                    {
                        
                            foreach (var Files in dir)
                            {
                            string[] s = Directory.GetFiles(Files);
                            foreach (var r in s)
                            {
                                Console.WriteLine(r);
                            }
                                Console.WriteLine(Files);
                            }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine(item);
            }

        }
    }
}
