using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    class Fish:Water_Animals
    {
        private double XCordinate;
        public void Sweam()
        {
            XCordinate += 10;

        }
        public  Fish(string name,int weight,string skin, string gills,string tail,double xcordinat)
            //:base(name:name,weight:weight,sckin:sckin,gills:gills,tail:tail)
        {
            XCordinate = xcordinat;
            Tail = tail;
            Gills = gills;
            Name = name;
            Weight = weight;
            Skin = skin;
        }
        public void PrinFish()
        {
            Console.WriteLine(Name);
        }
        public override void Eat()
        {
           
            Console.WriteLine("Dzuk@ kerav jrimur");
        }
    }
}
