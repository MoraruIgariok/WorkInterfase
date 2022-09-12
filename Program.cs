using System;

namespace workToInterface
{
    internal class Program
    {
        static void Menu()
        {
            bool forLoop = true;
            while (forLoop)
            {
	            /// В цикле есть функционал заполнения одной фигуры.
	            /// Можешь вынести функционал получение одной фигуры без вывода в отдельный метод? Пример IFigure WriteFigure();
	            /// До вызова метоода спрашиваешь сколько раз его вызвать = количество фигур которые я хочу ввести
	            /// Собрать результат выполнения метода в один массив-лист.
	            /// Вывести плошадь и периметр всех элементов массива.
                Console.WriteLine("\nCu ce figura lucram?\n");
                string[] keyWord = { "Dreptunghi.", "Cerc.", "Patrat.", "Triunghi.","Quit." };
                int i = 0;
                foreach (string word in keyWord)
                {
                    i++;
                    Console.WriteLine(i + "." + word);
                }
                int keys = Convert.ToInt32(Console.ReadLine());
                ///Можно же сократить количество кода)
                IFigure figure = null;
                switch (keys)
                {
                    case 1:
	                    figure = new Rectangular();
	                    break;
                    case 2:
	                    figure = new Circle();
                        break;
                    case 3:
                        figure = new Square();
                        break;
                    case 4:
                        figure = new Triangle();
                        break;
                    case 5:
                        forLoop = false;
                        break;
                    default:
                        Console.WriteLine("Asa solutii nu avem, mai incercati");
                        break;
                }

                if (figure != null)
                {
	                figure.Area();
	                figure.Perimeter();
                }
            } 
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lucram un pic? yes/no");
            string ok = Console.ReadLine();

            if(ok == "yes")
            {

                Menu();
                Console.WriteLine("------Ati iesit din sistem----");
                Console.WriteLine("------------------------------");
            }
            else
            {
                Console.WriteLine("Succese!");
            }
           
        
        }
    }
}
