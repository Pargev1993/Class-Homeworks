using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
   public class Cow:Land_Animal
    {
        public string Voise { get; set; }
        public double Remnant { get; set;}
        public Cow(string voise,double remnant,string behemoth,string leg,string name,int weight, string food,string skin)
        {
            Voise = voise;
            Remnant = remnant;
            Behemoth = behemoth;
            Leg = leg;
            Name = name;
            Weight = weight;
            Food = food;
            Skin = skin;

        }
        public void MeetSize(double Meet)
        {
            Meet = Weight / Remnant;
        }
        public override void Eat()
        {
            Console.WriteLine("Grass");
        }
    }
}
