using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_Class
{
    abstract class FetalTree : Tree
    {
        public string Fruit { get; set; }
        public abstract   bool ProducesOxygen();
        
        public FetalTree(string root, string branches, string leaves, int liveYear, double height, string froot) : base(root, branches, leaves, liveYear, height)
        {
            Fruit = froot;
        }
    }
}
