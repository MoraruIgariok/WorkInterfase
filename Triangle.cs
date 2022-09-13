using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{
   
       
    
    internal class Triangle : IFigure
    {

        public int side_1;
        public int side_2;
        public int side_3;
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
                double semiPerimetr = (side_1 + side_2 + side_3) / 2; // calculam semi perimetru.
                double aria = semiPerimetr * (semiPerimetr - side_1) * (semiPerimetr - side_2) * (semiPerimetr - side_3); //aproape aria
                return (decimal)Math.Sqrt(aria);
        }

        public decimal Perimeter()
        {
            return side_1 + side_2 + side_3;
        }

        public void WriteFigure()
        {
            Console.WriteLine("Aria triunghiului este {0} ", Area());
            Console.WriteLine("Perimetru triunghiului este {0} ",Perimeter());
        }
    }
}
