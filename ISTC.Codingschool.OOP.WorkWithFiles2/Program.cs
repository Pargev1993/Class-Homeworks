using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ISTC.Codingschool.OOP.WorkWithFiles2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plrase write a text");
            string text = Console.ReadLine();

            using (FileStream files = new FileStream(@"C:\Users\pqoal\Documents\txt.txt", FileMode.OpenOrCreate))
            {
                byte[] Array = System.Text.Encoding.Default.GetBytes(text);
                files.Write(Array, 0, Array.Length);
               var s= files.Position;
                files.Close();
            
            }
           
          
        }
    }
}
