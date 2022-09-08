using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{
    internal class Triunghi : IFigure
    {
        int l1;
        int l2;
        int l3;
        public Triunghi()
        {
            l1 = 0;
            l2 = 0;
            l3 = 0;
        }
        public Triunghi(int l1, int l2, int l3)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
        }
    
        public decimal Aria()
        {
            double p = (l1 + l2 + l3) / 2;
            double a =p * (p - l1) * (p - l2) * (p - l3);
            return (decimal)Math.Sqrt(a);
        }

       

        public decimal Perimetru()
        {
            return l1 + l2 + l3;
        }
    }
}
