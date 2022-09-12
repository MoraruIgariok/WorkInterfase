using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{      
    
    internal class Circle : IFigure
    {
        int radius;

        const decimal PI = 3.14m;

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
           return 2 * radius * PI; 
        }

        public void WriteFigure()
        {
            Console.WriteLine("Aria cercului este: {0}", Area()); 
            Console.WriteLine("Perimetru cercului este {0} ",Perimeter());
        }
    }
}
