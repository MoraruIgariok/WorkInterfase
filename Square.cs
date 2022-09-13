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
            return side * side;
        }

        public decimal Perimeter()
        {
            return 4 * side;
        }

        public void WriteFigure()
        {
            Console.WriteLine("Aria patratului este {0}",Area());
            Console.WriteLine("Perimetrul patratului este {0}",Perimeter());
        }
    }
}
