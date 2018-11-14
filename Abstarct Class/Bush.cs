using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_Class
{
   abstract class Bush:Tree
    {
        public string Flowers { get; set; }
        public abstract bool ProducesOxygen();
      
        public Bush(string root, string branches, string leaves, int liveYear, double height,string flowers)
                     :base(root,branches,leaves,liveYear,height)
        {
            Flowers = flowers;
        }
        
    }
}
