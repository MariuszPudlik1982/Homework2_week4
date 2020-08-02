using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisBas
{
    class Program
    {
        static void Main(string[] args)
        {
            string k;
            do
            {              
                double number;
                try
                {
                    Console.WriteLine("Podaj liczbę rzeczywistą");
                    number = double.Parse(Console.ReadLine());
                    var fisBas = new FisBas();
                    Console.WriteLine(fisBas.CheckNumber(number));
                }

                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Podałeś błędne dane");
                }
                
                Console.WriteLine("Jeśli chcesz przerwać wciśnij k, jeśli chcesz kontynuować wciśnij dowolny znak");
                k= Console.ReadLine();
            } while (k!="k");
            
        }
    }
}
