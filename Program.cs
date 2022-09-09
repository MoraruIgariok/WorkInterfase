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
                Console.WriteLine("\nCu ce figura lucram?\n");
                string[] keyWord = { "Dreptunghi.", "Cerc.", "Patrat.", "Triunghi.","Quit." };
                int i = 0;
                foreach (string word in keyWord)
                {
                    i++;
                    Console.WriteLine(i + "." + word);
                }
                int keys = Convert.ToInt32(Console.ReadLine());


                switch (keys)
                {
                    case 1:
                        IFigure rectangular = new Rectangular();
                        rectangular.Area();
                        rectangular.Perimeter();
                        break;
                    case 2:
                        IFigure circle = new Circle();
                        circle.Area();
                        circle.Perimeter();
                        break;
                    case 3:
                        IFigure square = new Square();
                        square.Area();
                        square.Perimeter();
                        break;
                    case 4:
                        IFigure triangle = new Triangle();
                        triangle.Area();
                        triangle.Perimeter();
                        break;
                    case 5:
                        forLoop = false;
                        break;
                    default:
                        Console.WriteLine("Asa solutii nu avem, mai incercati");
                        break;

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
