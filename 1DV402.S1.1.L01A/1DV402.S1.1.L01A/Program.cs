using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S1._1.L01A
{
    class Program
    {
        static void Main(string[] args)
        {
            double total;
            
            int betalat;
            
            while(true)
            {

                try
                {


                    // här matar man in totalsumma 
                    Console.Write("Ange totalsumma:");
                    total = double.Parse(Console.ReadLine());

                    if (total < 0.50)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Suman är för liten, köp genomförs inte");
                        Console.ResetColor();
                    }
                  
                    else
                    {
                        break;
                    }

                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("det är inte en siffra");
                    Console.ResetColor();
                }
            
            }


   
        }
    }
}

