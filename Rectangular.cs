using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{
    class RectangularCount
    {
        public int count { get; set; } 
        public int width { get; set; }
        public int length { get; set; } 
    }
    internal class Rectangular : IFigure
    {
       List<RectangularCount> rectsList = new List<RectangularCount>();

        public Rectangular()
        {
            Console.WriteLine("Cite figuri alegeti ? ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i < number; i++)
            {
                var rect = new RectangularCount();
                rect.count = i;
                Console.Write("Introduceti lungimea: ");
                rect.length = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduceti latimea: ");
                rect.width = Convert.ToInt32(Console.ReadLine());

                rectsList.Add(rect);

            }
            Console.WriteLine("********************************");
            
        }
        public decimal Area()
        {
            foreach(var item in rectsList)
            {
                Console.WriteLine("Aria dreptunghiului {0} este {1} ", item.count + 1, item.length * item.width);
            }
            Console.WriteLine("--------------------------------------");
            return 0;
        }

        public decimal Perimeter()
        {
            foreach (var item in rectsList)
            {
                Console.WriteLine("Perimetru dreptunghiului {0} este {1} ", item.count + 1, 2 * (item.length + item.width));
            }
            Console.WriteLine("--------------------------------------");
            return 0;   
        }
    }
}
