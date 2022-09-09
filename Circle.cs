using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{
    internal class Circle : IFigure
    {
        const decimal PI = 3.14m;
        int radius;

        public Circle()
        {
            Console.Write("Introduceti raza: ");
            radius = Convert.ToInt32(Console.ReadLine());
        }

        public decimal Area()
        {
            return PI * radius * radius; 
        }

        public decimal Perimeter()
        {
            return 2 * PI * radius;
        }
    }
}
