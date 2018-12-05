using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.Secondcours.Generic
{
    class Program
    {
        public static T Converter<T>(string str)
        {
            T result = default(T);
            result = (T)Convert.ChangeType(str, typeof(T));
            Console.WriteLine(str);
            return result;
        }
        static void Main(string[] args)
        {
            string str = "123";
            Converter<double>(str);
        }
    }
}
