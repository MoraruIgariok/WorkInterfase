using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{
    internal class Cerc : IFigure
    {
        const decimal PI = 3.14m;
        int r;

        public Cerc()
        {
            r= 0;   
        }

        public Cerc(int r)
        {
            this.r = r;
        }

        public decimal Aria()
        {
            return PI * r * r; 
        }

        public decimal Perimetru()
        {
            return 2 * PI * r;
        }
    }
}
