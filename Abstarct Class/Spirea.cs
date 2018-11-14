using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstarct_Class
{
    class Spirea:Bush
    {
        public bool FlowersColor { get; set; }
        public string Weather { get; set; }
        
        public Spirea(string root, string branches, string leaves, int liveYear, double height, string flowers, bool flowersColor, string weather) : base(root,branches,leaves,liveYear,height,flowers)
        {
            FlowersColor = flowersColor;
            Weather = weather;
        }
        public override bool ProducesOxygen()
        {
            return true;
        }
        public string PrintSpirea()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return $"This is Fetal tree,his name is Spirea,his roots are {Root},his leaves color is {Leaves}, live year {LiveYear},flowers color is {FlowersColor}";
        }

    }
}
