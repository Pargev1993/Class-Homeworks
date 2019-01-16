using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Exeptions.RuntimeException.exemp2
{

    class Program : System.Attribute
    {
        static void RunMyApplication()
        {
            int s = 0;
            int d = 20;
            int z = s / d;
        }
        [HandleProcessCorruptedStateExceptions]
        static int Main(string[] args)
        {
            try
            {
               
                RunMyApplication();
                throw new Exception();
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("error! ", ex.Message);
                return -1;
            }
            return 0;
        }
    }
}
