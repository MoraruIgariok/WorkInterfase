using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{
    public class TriangleCount
    {
        public int count { get; set; }
        public int side_1 { get; set; } 
        public int side_2 { get; set; } 
        public int side_3 { get; set; } 
    }
    internal class Triangle : IFigure
    {
        List<TriangleCount> trianglesList = new List<TriangleCount>();
        public Triangle()
        {
            Console.WriteLine("Cite figuri alegeti ?");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var triangle = new TriangleCount();

                triangle.count = i;
                Console.Write("Introduceti l1: ");
                triangle.side_1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduceti l2: ");
                triangle.side_2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduceti l3: ");
                triangle.side_3 = Convert.ToInt32(Console.ReadLine());

                trianglesList.Add(triangle);
            }

            Console.WriteLine("********************************");

        }
      
    
        public decimal Area()
        {
            foreach(var item in trianglesList)
            {
                double semiPerimetr = (item.side_1 + item.side_2 + item.side_3) / 2;
                double aria = semiPerimetr * (semiPerimetr - item.side_1) * (semiPerimetr - item.side_2) * (semiPerimetr - item.side_3);
                Console.WriteLine("Aria triunghiului {0} este {1} ", item.count + 1, (decimal)Math.Sqrt(aria));

            }
            Console.WriteLine("--------------------------------------");
            return 0;
        }

       

        public decimal Perimeter()
        {
            foreach(var item in trianglesList)
            {
                Console.WriteLine("Perimetru triunghiului {0} este {1} ", item.count+1, item.side_1 + item.side_2 + item.side_3);
            }
            Console.WriteLine("--------------------------------------");
            return 0;
        }
    }
}
