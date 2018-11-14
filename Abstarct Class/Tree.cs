using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_Class
{
   abstract class Tree
    {
        public string Root { get; set; }
        public string Branches { get; set; }
        public string Leaves { get; set; }
        public int LiveYear { get; set; }
        public double Height { get; set; }
        
        
        public Tree(string root, string branches, string leaves,  int liveYear,double height)
        {
            Root = root;
            Branches = branches;
            Leaves = leaves;
            LiveYear = liveYear;
            Height = height;
        }
        
    }
}
