using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Types
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
            int? i = dr.GetIntFromDatabase();
            if (i.HasValue)
                Console.WriteLine("Value of 'i' is: {0}", i.Value);
            else
                Console.WriteLine("Value of 'i' is undefined."); 
            bool? b = dr.GetBoolFromDatabase();
            if (b.HasValue)
                Console.WriteLine("Value of 'b' is: {0}", b.Value);
            else
                Console.WriteLine("Value of 'b' is undefined.");
        }
    }
}
