<<<<<<< HEAD
  using System;
using System.Collections;

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
                
                string[] keyWord = { "Dreptunghi.", "Cerc.", "Patrat.", "Triunghi.","Quit." };//lista de cuvinte din meniu.
               
                int i = 0; //numarul liniei.
                foreach (string word in keyWord)
                {
                    i++;
                    Console.WriteLine(i + "." + word);
                }
                //afisarea meniului

                int keys = Convert.ToInt32(Console.ReadLine());//selectam figura din meniu
                ///Можно же сократить количество кода)
                ///
                var Ara_Prime = new ArrayList();

                IFigure figure = null;
                switch (keys)
                {
                    case 1:
	                    figure = new Rectangular();
                        Ara_Prime.Add(figure);  
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
                    foreach(int item in Ara_Prime)
                    {
                        item.Equals(figure);    
                    }
                                        
                }
            } 
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lucram un pic? yes/no");
            string ok = Console.ReadLine();

            if(ok == "yes")
            {
                 
                Console.WriteLine("Cite figuri alegeti ?");

                int NumberFigure = Convert.ToInt32(Console.ReadLine()); /// aici salvam numarul de figuri dat de utilizator.
                
                   
                if (NumberFigure > 0)
                {
                    Menu();                                     
                }
                else
                {
                    Console.WriteLine("\"0\" tac \"0\" sa fie");
                }
                
            }
            else
            {
                Console.WriteLine("Succese!");
            }
           
        
        }
    }
=======
using System;
using System.Collections.Generic;

namespace workToInterface
{
	internal class Program
	{
		static void Menu()
		{
			bool forLoop = true;
			///Добавь выбор количества фигур.
			while (forLoop)
			{
				var figure = CreateFigure();

				if (figure != null)
				{
					figure.WriteFigure();
				}
				else
				{
					forLoop = false;
				}
			}

		}

		static IFigure CreateFigure()
		{
			Console.WriteLine("\nCu ce figura lucram?\n");
			string[] keyWord = { "Dreptunghi.", "Cerc.", "Patrat.", "Triunghi.", "Quit.", "Exit" };//lista de cuvinte din meniu.
			int i = 0; //numarul liniei.
			foreach (string word in keyWord)
			{
				i++;
				Console.WriteLine(i + "." + word);
			}
			//afisarea meniului

			int keys = Convert.ToInt32(Console.ReadLine());//selectam figura din meniu
			///Можно же сократить количество кода)
			IFigure figure = null;
			switch (keys)
			{
				case 1:
					return new Rectangular();
				case 2:
					return new Circle();
				case 3:
					return new Square();
				case 4:
					return new Triangle();
				case 5:
					return null;
				default:
					Console.WriteLine("Asa solutii nu avem, mai incercati");
					return null;
			}
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Lucram un pic? yes/no");
			string ok = Console.ReadLine();

			if (ok == "yes")
			{
				Console.WriteLine("Cite figuri alegeti ?");

				int NumberFigure = Convert.ToInt32(Console.ReadLine()); /// aici salvam numarul de figuri dat de utilizator.
				if (NumberFigure > 0)
				{
					Menu();
					Console.WriteLine("------Ati iesit din sistem----");
					Console.WriteLine("------------------------------");
				}
				else
				{
					Console.WriteLine("0 tac 0 sa fie");
				}

			}
			else
			{
				Console.WriteLine("Succese!");
			}


		}
	}
>>>>>>> 3763fca5d231b41f872258132e47164e031ad630
}
