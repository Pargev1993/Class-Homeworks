using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_
{
    public delegate void Mydelegate();
    class Myclass
    {
      
        public void CallMethod1()
        {
            Console.WriteLine("Method1");
        }
        public void Calldelegate2()
        {
            Console.WriteLine("Method 2");
        }
        public void Calldelegate3()
        {
            Console.WriteLine("Method 3");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Myclass myclass = new Myclass();

            Mydelegate mydelegate = null;
            //mydelegate += myclass.CallMethod1;
            //mydelegate += myclass.Calldelegate2;
            //mydelegate += myclass.Calldelegate3;
            //mydelegate();
            //mydelegate -= myclass.Calldelegate2;
            //mydelegate();
            Mydelegate newMydelegate = new Mydelegate( myclass.CallMethod1);
            Mydelegate mydelegate1 = new Mydelegate(myclass.Calldelegate2);
            Mydelegate mydelegate2 = new Mydelegate(myclass.Calldelegate3);
            mydelegate = newMydelegate + mydelegate1 + mydelegate2;

            Console.WriteLine("Enter number from 1-7");
            string chois = Console.ReadLine();
            switch (chois)
            {
                case "1":
                    mydelegate.Invoke();
                    break;
                case "2":
                    mydelegate1.Invoke();
                    break;
                case "3":
                    mydelegate2.Invoke();
                    break;
                case "5":
                    Mydelegate Mydelegate3 = mydelegate - mydelegate1;
                    Mydelegate3();
                    break;
            }




        }
    }
}
