using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exem_1
{
    class DatabaseReader
    {
        public int? numericValue = null;
        public bool? boolValue = true;
        public int? GetIntFromDatabase()
        {
            return numericValue;
        }
        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseReader dr = new DatabaseReader();
            int myData = dr.GetIntFromDatabase() ?? 100;
            Console.WriteLine("Value of myData: {0}", myData);
            Console.ReadLine();
        }
    }
}

