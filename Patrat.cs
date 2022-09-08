using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{
    internal class Patrat : IFigure
    {
        int l;
       public Patrat()
        {
            l = 0;
        }
        public Patrat(int l)
        {
            this.l = l;
        }

        public decimal Aria()
        {
            return (decimal)l * l;
        }

        public decimal Perimetru()
        {
            return (decimal)4*l;
        }
    }
}
