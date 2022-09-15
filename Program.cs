
using System;
using System.Collections;
using System.Collections.Generic;

namespace workToInterface
{
	internal class Program
	{	

		static void Menu()
		{
			bool forLoop = true;
					
			Console.WriteLine("How many figures do you want to select ?? ");

			int NumberFigure = Convert.ToInt32(Console.ReadLine());


			while (forLoop) 
			{
				var figure = CreateFigure();

				var listFigure = new List<IFigure>();
				
				for (int i = 0; i < NumberFigure; i++)
				{
					listFigure.Add(CreateFigure());
				}

				if (figure != null)
					{				
						foreach(IFigure item in listFigure)
						{
							Console.WriteLine("Aria {0},Perime {1}",item.Area(),item.Perimeter());
						}
					}
					else
					{
						forLoop = false;
					}
				
			}

		}

		static IFigure CreateFigure()
		{
			Console.WriteLine("\nWhat figure do you select ?\n");
			string[] keyWord = { "Dreptunghi.", "Cerc.", "Patrat.", "Triunghi.", "Exit" };
			int i = 0;
			foreach (string word in keyWord)
			{
				i++;
				Console.WriteLine(i + "." + word);
			}
						
			int keys = Convert.ToInt32(Console.ReadLine()); //option from menu

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

			Console.WriteLine("Do you want to work ? yes/no");

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
