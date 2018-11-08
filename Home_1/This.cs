using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_1
{
    class This
    {
       public string FName;
        public string LName;
        public int Age;
        public double Weight;
        public String Gender;
        public This(String FName)
        {
            this.FName = FName;
        }
        public This(string FName, string LName) : this(FName)
        {
            this.LName = LName;
        }
          public This (string FName,string LName,int Age):this(FName,LName)
        {
            this.Age = Age;
        }
        public This(string FName, string LName, int Age,double Weight) : this(FName, LName,Age)
        {
            this.Weight = Weight;
        }
        public This(string FName, String LName, int Age, Double Weight, String Gender) : this(FName: FName, Age: Age, LName: LName, Weight: Weight)
        {
            this.Gender = Gender;
        }
        

    }
}
