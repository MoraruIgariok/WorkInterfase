
using System;
using System.Collections.Generic;

namespace workToInterface
{
	internal class Program
	{
		static void Menu()
		{
			bool forLoop = true;
			
			Console.WriteLine("Cite figuri alegem? ");
			int NumberFigure = Convert.ToInt32(Console.ReadLine());

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
			string[] keyWord = { "Dreptunghi.", "Cerc.", "Patrat.", "Triunghi.", "Exit" };//lista de cuvinte din meniu.
			int i = 0; //numarul liniei.
			foreach (string word in keyWord)
			{
				i++;
				Console.WriteLine(i + "." + word);
			}
			//afisarea meniului

			int keys = Convert.ToInt32(Console.ReadLine());//selectam figura din meniu
			///Можно же сократить количество кода)
			

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
				Menu();						
			}
			else
			{
				Console.WriteLine("Succese!");
			}


		}
	}
}
