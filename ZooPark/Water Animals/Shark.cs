using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    class Shark:Water_Animals
    {
        public Shark(int tooth, string gills, string tail, string name, int weight, string skin) //: base(gills: gills, tail: tail, name: name, sckin: sckin, weight:weight)
        {
            Tail = tail;
            Gills = gills;
            Tooth = tooth;
            Name = name;
            Weight = weight;
            Skin = skin;
        }
        public int Tooth { get; set; }
        public void Eat(string Food)
        {
            Food = "Meat";
        }
        public override void Eat()
        {
            Console.WriteLine("Akulan kerav mis");
        }
        public void PrintShark()
        {
            Console.WriteLine($"This is Shark!");
        }
    }
}
