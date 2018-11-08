using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_1
{
    class Human
    {
       public string FName;
        public string LName;
        public int Age;
        public double Weight;
        public String Gender;
        public Human(String FName)
        {
            this.FName = FName;
        }
        public Human(string FName, string LName) : this(FName)
        {
            this.LName = LName;
        }
          public Human (string FName,string LName,int Age):this(FName,LName)
        {
            this.Age = Age;
        }
        public Human(string FName, string LName, int Age,double Weight) : this(FName, LName,Age)
        {
            this.Weight = Weight;
        }
        public Human(string FName, String LName, int Age, Double Weight, String Gender) : this(FName: FName, Age: Age, LName: LName, Weight: Weight)
        {
            this.Gender = Gender;
        }
        
        public string PrintAll()
        {
            return $"My Name: {FName}.\nLast name:{LName}.\nMy age: {Age}.\nMy weight: {Weight}.\nI am a {Gender}.";
        }

    }
}
