using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exem_3
{
    class User
    {
        public Director director { get;set; }
    }
    class Director
    {
        public Human human { get; set; }
    }
    class Human
    {
        public string Name { get; set; } = "Smit";
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            string a = user?.director?.human?.Name?? "jon";
            Console.WriteLine(a);
            
        }
    }
}
