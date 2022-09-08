using System;

namespace workToInterface
{
    internal class Program
    {
        static void Menu()
        {
            Console.WriteLine("Cu ce figura lucram?");
            string[] keyWord = { "Dreptunghi.", "Cerc.", "Patrat.", "Triunghi." };
            int i = 0;
            foreach(string word in keyWord)
            {
                i++;
                Console.WriteLine(i+"."+word);                
            } 
            int s = Convert.ToInt32(Console.ReadLine());
            switch (s)
            {
                case 1:
                    Console.WriteLine("Introduceti lungimea: ");
                    int l = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduceti latimea: ");
                    int w = Convert.ToInt32(Console.ReadLine());
                    IFigure dreptunghi = new Dreptunghi(l, w);
                    decimal a_d = dreptunghi.Aria();
                    Console.WriteLine("Aria dreptunghi este:{0}", a_d);
                    decimal p_d = dreptunghi.Perimetru();
                    Console.WriteLine("Perimetrul dreptunghi este:{0}", p_d);
                    break;
                case 2:
                    Console.WriteLine("Introduceti raza: ");
                    int r = Convert.ToInt32(Console.ReadLine());
                    IFigure cerculet = new Cerc(r);
                    decimal a_c = cerculet.Aria();
                    Console.WriteLine("Aria cerc este:{0}", a_c);
                    decimal p_c = cerculet.Perimetru();
                    Console.WriteLine("Perimetrul cerc este:{0}", p_c);
                    break;
                case 3:
                    Console.WriteLine("Introduceti lungimea: ");
                    int latur = Convert.ToInt32(Console.ReadLine());
                    IFigure patrat = new Patrat(latur);
                    decimal a_l = patrat.Aria();
                    Console.WriteLine("Aria cerc este:{0}", a_l);
                    decimal p_l = patrat.Perimetru();
                    Console.WriteLine("Perimetrul cerc este:{0}", p_l);
                    break;
                case 4:
                    Console.WriteLine("Introduceti l1: ");
                    int l_1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduceti l2: ");
                    int l_2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduceti l3: ");
                    int l_3 = Convert.ToInt32(Console.ReadLine());
                    IFigure triunghi = new Triunghi(l_1,l_2,l_3);
                    decimal a_t = triunghi.Aria();
                    Console.WriteLine("Aria cerc este:{0}", a_t);
                    decimal p_t = triunghi.Perimetru();
                    Console.WriteLine("Perimetrul cerc este:{0}", p_t);
                    break;




            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lucram un pic? yes/no");
            string ok = Console.ReadLine();

            if(ok == "yes")
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
