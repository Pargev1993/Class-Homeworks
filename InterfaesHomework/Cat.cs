using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaesHomework
{
    class Cat:Animal
    {
        public string  Type { get; set; }
        public Cat(string type)
        {
            Type = type;
        }
    }
}
