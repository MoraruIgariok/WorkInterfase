using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{
    internal class Dreptunghi : IFigure
    {
        int length;
        int width;

        public Dreptunghi()
        {
            length =0;
            width = 0;
        }
        public Dreptunghi(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

            public decimal Aria()
        {
            return length * width;
        }

        public decimal Perimetru()
        {

            return 2 * (length + width);   
        }
    }
}
