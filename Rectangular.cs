using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workToInterface
{
    /// <summary>
    ///Опиши что за фигура
    /// </summary>
    internal class Rectangular : IFigure
	{
		/// <summary>
		/// Добавиь коментарии к переменным, и по идеи они приватные не радектируесые)
		/// </summary>
		public int width { get; set; }

		//private readonly int width;

		public int length { get; set; }
		//private readonly int length;

        public Rectangular()
        {
            Console.WriteLine("********************************");
            ///todo тут оставить только заполнение текушей фигуры)
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
    }
}
