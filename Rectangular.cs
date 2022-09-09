using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{
    internal class Rectangular : IFigure
    {
        Dictionary<int, int> _rectangular = new Dictionary<int, int>();        
        int length;
        int width;       

        public Rectangular()
        {
            Console.WriteLine("Cite figuri alegeti");
            int number = Convert.ToInt32(Console.ReadLine());
                
            for (int i = 0; i < number; i++)
            {
                Console.Write("Introduceti lungimea: ");
                length = Convert.ToInt32(Console.ReadLine());
                Console.Write("Introduceti latimea: ");
                width = Convert.ToInt32(Console.ReadLine());
            }
        }
        public decimal Area()
        {
            return length * width;
        }

        public decimal Perimeter()
        {

            return 2 * (length + width);   
        }
    }
}
