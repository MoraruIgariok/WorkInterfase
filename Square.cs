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
      List<SquareCount> squaresList = new List<SquareCount> ();
       public Square()
        {
            Console.WriteLine("Cite figuri alegeti? ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < number; i++)
            {
                var squerList = new SquareCount();
                squerList.count = i;
                Console.Write("Introduceti lungimea: ");
                squerList.side = Convert.ToInt32(Console.ReadLine());
                squaresList.Add(squerList);  
            }
            Console.Write("************************************\n");

        }
       public decimal Area()
        {
            foreach (var item in squaresList)
            {
                Console.WriteLine("Aria patraturlui {0} este {1}", item.count + 1, item.side * item.side);
            }
            Console.WriteLine("------------------------------------------------------");
            return 0;
        }

        public decimal Perimeter()
        {
            foreach (var item in squaresList)
            {
                Console.WriteLine("Perimetrul patraturlui {0} este {1}", item.count + 1, item.side * 4);
            }
            Console.WriteLine("------------------------------------------------------");
            return 0;
        }
    }
}
