using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{
    public class SquareCount
    {
        public int count { get; set; } 
        public int side { get; set; }    
    }
    internal class Square : IFigure
    {
        List<SquareCount> squareList = new List<SquareCount>();
        
       public Square()
        {

            Console.WriteLine("Cite figuri alegeti ?");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var square = new SquareCount();

                square.count = i;
                Console.Write("Introduceti lungimea: ");
                square.side = Convert.ToInt32(Console.ReadLine());

                squareList.Add(square);

            }
            Console.WriteLine("********************************");
        }
       public decimal Area()
        {
            foreach (var item in squareList)
            {
                Console.WriteLine("Aria patratului {0} este {1} ", item.count + 1, item.side * item.side);
            }
            Console.WriteLine("--------------------------------------");
            return 0;
        }

        public decimal Perimeter()
        {
            foreach (var item in squareList)
            {
                Console.WriteLine("Aria patratului {0} este {1} ", item.count + 1, 4 * item.side);
            }
            Console.WriteLine("--------------------------------------");
            return 0;
        }
    }
}
