using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    public class Animals
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public string Skin { get; set; }
        public string Food { get; set; }
        // public Animals(string skin,int weight,string name)
        // {
        //     Skin = skin;
        //     Weight = weight;
        //     Name = name;
        //
        // }
        public virtual void Eat ()
        {
            Console.WriteLine("Ker ");
        }
    } 
}
