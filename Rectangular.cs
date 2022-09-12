using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{
    /// <summary>
    ///clasa dreptunghi cu constructor de primirea datelor si implementeaza metodele din interfata Aria si Perimetru.
    /// </summary>
    internal class Rectangular : IFigure
	{
        /// <summary>
        /// Добавиь коментарии к переменным, и по идеи они приватные не радектируесые)
        /// </summary>
        public int width;

        //private readonly int width;

        public int length;
		//private readonly int length;

        public Rectangular()
        {
            
            Console.Write("Introduceti lungimea: ");
            length= Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti latimea: ");
            width = Convert.ToInt32(Console.ReadLine());
        }
        public decimal Area()
        {
            ///метод возвраяшет результат расчета а не выводит его
	        return length * width;
        }

        public decimal Perimeter()
        {
	        ///метод возвраяшет результат расчета а не выводит его
	        return 2 * (length + width);
        }
        public void WriteFigure()
        {
            
            Console.WriteLine("Aria figurii este: {0}", Area());
            Console.WriteLine("Perimetrul figurii este: {0}", Perimeter());
        }
    }
}
