  using System;
using System.Collections;

namespace workToInterface
{
    internal class Program
    {

        static void Menu(int n)
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
                    Menu(NumberFigure);                                     
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
}
