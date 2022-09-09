using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{
    public class CircleCount
    {
        public int count { get; set; }  
        public int radius { get; set; }

        public const decimal PI = 3.14m;
    }
    internal class Circle : IFigure
    {
        List<CircleCount> circlesList = new List<CircleCount>();

        public Circle()
        {
            Console.WriteLine("Cite figuri alegeti ?");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i =0; i < number; i++)
            {
                var circle = new CircleCount();

                circle.count = i;
                Console.Write("Introduceti raza: ");
                circle.radius = Convert.ToInt32(Console.ReadLine());
                circlesList.Add(circle);    

            }
            Console.WriteLine("********************************");

        }

        public decimal Area()
        {
            foreach(var item in circlesList)
            {
                Console.WriteLine("Aria cercului {0} este {1} ", item.count + 1, item.radius * item.radius * CircleCount.PI);
            }
            Console.WriteLine("--------------------------------------");
            return 0; 
        }

        public decimal Perimeter()
        {
            foreach (var item in circlesList)
            {
                Console.WriteLine("Perimetru cercului {0} este {1} ", item.count + 1, 2 * item.radius * CircleCount.PI); 
            }
            Console.WriteLine("--------------------------------------");
            return 0;
        }
    }
}
