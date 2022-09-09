using System;
using System.Collections.Generic;

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
                        Console.WriteLine("Aria dreptunghi este:{0}", rectangular.Area());
                        Console.WriteLine("Perimetrul dreptunghi este:{0}", rectangular.Perimeter());
                        break;
                    case 2:
                        IFigure cerculet = new Circle();
                        Console.WriteLine("Aria cerc este:{0}", cerculet.Area());
                        Console.WriteLine("Perimetrul cerc este:{0}", cerculet.Area());
                        break;
                    case 3:
                        IFigure patrat = new Square();
                        Console.WriteLine("Aria patratului este:{0}", patrat.Area());
                        Console.WriteLine("Perimetrul patratului este:{0}", patrat.Perimeter());
                        break;
                    case 4:
                        IFigure triangle = new Triangle();
                        Console.WriteLine("Aria triunghiului este:{0}", triangle.Area());
                        Console.WriteLine("Perimetrul triunghiului este:{0}", triangle.Perimeter());
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
