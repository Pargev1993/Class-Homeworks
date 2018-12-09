using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{

    class KFCBranch
    {
        public string Branches { get; set; }
        public double Rating { get; set; }
    }
    class KFcWorkers
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
    }
    class Kfc
    {
        public string Name { get; set; }
        public double SaleRaiting { get; set; }
        public double TastyRaiting { get; set; }
        public int ValueOfPrise { get; set; }
        public string TypeOfFood { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Food = new List<Kfc>
            {
               new Kfc{Name="Twister",SaleRaiting=45,TastyRaiting=95,ValueOfPrise=1150,TypeOfFood="Sandwich"},
               new Kfc {Name="Bigger",SaleRaiting=3.8,TastyRaiting=80,ValueOfPrise=1600,TypeOfFood="Burger" },
               new Kfc{Name="Boksmaster",SaleRaiting=65.3,TastyRaiting=90,ValueOfPrise=1550,TypeOfFood="Sandwich"},
               new Kfc{Name="Strips",SaleRaiting=87.5,TastyRaiting=98,ValueOfPrise=650,TypeOfFood="pieces of chicken"},
               new Kfc{Name="Spice wings",SaleRaiting=86.5,TastyRaiting=96,ValueOfPrise=850,TypeOfFood="pieces of chicken"},
               new Kfc {Name="Original Pieces",SaleRaiting=29,TastyRaiting=74,ValueOfPrise=600,TypeOfFood="pieces of chicken"},
               new Kfc{Name="ShefBurger",SaleRaiting=86.5,TastyRaiting= 97,ValueOfPrise=1150,TypeOfFood="Burger"},
            };

            var Workers = new List<KFcWorkers>
            {
                new KFcWorkers {Name="Lilia",Position="cashier",Salary=80000},
                new KFcWorkers{Name ="Bill",Position="Cooker",Salary=90000},
                new KFcWorkers{Name ="James",Position="Trainer",Salary=110000},
                new KFcWorkers{Name ="Mari",Position="Cashier",Salary=80000},
                new KFcWorkers{Name ="Mariam",Position="Trainer",Salary=110000},
                new KFcWorkers{Name ="Jhon",Position="Manager",Salary=200000},
                new KFcWorkers{Name ="James",Position="director",Salary=300000},
                new KFcWorkers{Name ="Bill",Position="Deputy Director",Salary=90000},
            };

            var Branch = new List<KFCBranch>
            {
                new KFCBranch{Branches="Moskovtan",Rating=26.8},
                new KFCBranch{Branches="Yerevan Mall",Rating=35.9},
                new KFCBranch{Branches="Dalma Mall",Rating=20.3},
                new KFCBranch{Branches="Komitas",Rating=17},
            };


            var Burgers =
                from BestBurgers in Food
                where BestBurgers.TypeOfFood == "Burger"
                orderby BestBurgers.Name,BestBurgers.SaleRaiting
                select new
                {
                    raiting=BestBurgers.SaleRaiting,
                    Name = BestBurgers.Name
                };
            //foreach (var Item in Burgers)
            //{
            //    Console.WriteLine($"Burgers are: {Item.Name} ");
            //}
            //Console.WriteLine(new string('*', 50));
            var Work =
                from Worker in Workers
                where Worker.Position == "cashier"
                join Foods in Food
               on Food
                into OurWorjers








            var sandwich =
                from BestSandwich in Food
                where BestSandwich.TypeOfFood == "Sandwich"
                orderby BestSandwich.Name
                select new
                {
                    name = BestSandwich.Name
                };
            foreach (var Item in sandwich)

                Console.WriteLine($"Best Sandwiches are {Item.name}");
            Console.WriteLine(new string('*', 50));

            var BastTastFoods =
                from BestFood in Food
                where BestFood.TastyRaiting > 80
                orderby BestFood.Name
                select new
                {
                    name = BestFood.Name

                };
            foreach (var item in BastTastFoods)
                Console.WriteLine("Best Foods in KFC are: " + item.name);
            Console.WriteLine(new string('*', 50));

            var ExpensiveFood =
               from ExpFood in Food
               where ExpFood.ValueOfPrise > 1000
               orderby ExpFood.Name
               select new
               {
                   name = ExpFood.Name
               };
            foreach (var item in BastTastFoods)
                Console.WriteLine("The Most expensive Foods Are " + item.name);
            Console.WriteLine(new string('*', 50));



        }
    }
}