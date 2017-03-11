using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mouse
{
    class Mouse
    {
        public int pozX {get;set;}
        public int pozY {get;set;}
        public int butttonOn { get; set; }
        public Mouse()
        {
            pozX = 10;
            pozY = 8;
            butttonOn = 1;
        }
        public Mouse(int X,int Y)
        {
            pozX = X;
            pozY = Y;
            butttonOn = 1;
        }
    }
}
