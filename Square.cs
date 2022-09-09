using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{
    internal class Square : IFigure
    {
        int side;
       public Square()
        {
            Console.Write("Introduceti lungimea: ");
            side = Convert.ToInt32(Console.ReadLine());
        }
       public decimal Area()
        {
            return (decimal)side * side;
        }

        public decimal Perimeter()
        {
            return (decimal)4*side;
        }
    }
}
