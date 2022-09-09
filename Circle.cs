using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{
    class CountCircle
    {
        public int count { get; set; }  
        public int radius { get; set; }

        public const decimal PI = 3.14m;

    }
    internal class Circle : IFigure
    {

        List<CountCircle> circlesList = new List<CountCircle>();
        public Circle()
        {
            
            Console.WriteLine("Cite figuri alegeti? ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var circle = new CountCircle(); 
                
                circle.count = i; //numarul de figuri.

                Console.Write("Introduceti raza: ");
                circle.radius = Convert.ToInt32(Console.ReadLine());

                circlesList.Add(circle); //adaugarea in lista.   
            }
            Console.Write("************************************\n");


        }

        public decimal Area()
        {
            foreach (var item in circlesList)
            {
                Console.WriteLine("Aria pentru cercu {0} este {1} ", item.count +1, item.radius*item.radius * CountCircle.PI);
            }
            Console.WriteLine("------------------------------------------------------");
            return 0; 
        }

        public decimal Perimeter()
        {
            foreach (var item in circlesList)
            {
                Console.WriteLine("Perimetrul pentru cercu {0} este {1} ", item.count + 1, 2 * (item.radius * CountCircle.PI));
            }
            Console.WriteLine("------------------------------------------------------");
            return 0;
            
        }
    }
}
