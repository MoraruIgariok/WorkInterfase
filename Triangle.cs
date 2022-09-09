using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{
    internal class Triangle : IFigure
    {
        int side_1;
        int side_2;
        int side_3;
        public Triangle()
        {
            Console.Write("Introduceti l1: ");
            side_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti l2: ");
            side_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti l3: ");
            side_3 = Convert.ToInt32(Console.ReadLine());
        }
      
    
        public decimal Area()
        {
            double p = (side_1 + side_2 + side_3) / 2;
            double a =p * (p - side_1) * (p - side_2) * (p - side_3);
            return (decimal)Math.Sqrt(a);
        }

       

        public decimal Perimeter()
        {
            return side_1 + side_2 + side_3;
        }
    }
}
