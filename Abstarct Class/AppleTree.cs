using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_Class
{
    class AppleTree : FetalTree
    {
        public string Name { get; set; }
        public AppleTree(string root, string branches, string leaves, int liveYear, double height, string fruit, string name)
                         : base(root, branches, leaves, liveYear, height, fruit)
        {
            Name = name;
        }
        public override bool ProducesOxygen()
        {
            return true;
        }
        public string PrintAppleTree()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            return $"This is Apple tree his height is {Height},its have very {Root} roots, very {Branches} branches,his fruit an {Fruit} ";
        }
    }
}