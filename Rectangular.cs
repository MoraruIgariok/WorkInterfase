using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{
    public class RectangularCount
    {
        public int counter { get; set; }

        public int length { get; set; }

        public int width { get; set; }

       
    }
    internal class Rectangular : IFigure
    {
        List<RectangularCount> figureHelpList = new List<RectangularCount>();
        
        public Rectangular()
        {
            Console.WriteLine("Cite figuri alegeti? ");
            int number = Convert.ToInt32(Console.ReadLine());
             
            for (int i = 0; i < number; i++)
            {
                var rectList = new RectangularCount();

                rectList.counter = i;
                Console.Write("Introduceti lungimea: ");
                rectList.length = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduceti latimea: ");
                rectList.width = Convert.ToInt32(Console.ReadLine());

                figureHelpList.Add(rectList);
            }
            Console.Write("************************************\n");
        }
        public decimal Area()
        {
            foreach (var item in figureHelpList)
            {
                Console.WriteLine("Aria dreptunghi {0} este:{1}", item.counter + 1, item.length * item.width);
            }
            Console.WriteLine("------------------------------------------------------");
            return 0;
        }

        public decimal Perimeter()
        {
            foreach (var item in figureHelpList)
            {
                Console.WriteLine("perimetru dreptunghi {0} este:{1}", item.counter + 1, 2 * (item.length + item.width));
            }
            Console.WriteLine("------------------------------------------------------");
            return 0;
        }
    }
}
