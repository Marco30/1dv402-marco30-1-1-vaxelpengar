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

            while (true) //loop startat och loppar förevigt om inte den avlutas med break; 
            {

                try // öppnar up möjligheten att hantera fel chatch som kan uppstå i programmet  
                {


                    // här matar man in totalsumma 
                    Console.Write("Ange totalsumma:");
                    total = double.Parse(Console.ReadLine());

                    if (total < 0.50) // det här visas om beloppet man får är mindre än en krona 
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Suman är för liten, köp genomförs inte");
                        Console.ResetColor();
                    }

                    else // är det mer än en krona avlutat loppen med break  
                    {
                        break;
                    }

                }
                catch // skriver man en bokstav, punkt eller något som inte uppfattas som ett tal så visas det här 
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("det är inte en siffra");
                    Console.ResetColor();
                }
            
            }

            int b = (int)Math.Round(total);

            while (true)
            {
                try 
                {
                    Console.Write("mottaget belopp:");
                    betalat = int.Parse(Console.ReadLine());
                   
                    if (betalat >= b)
                    {
                        break;
                    }
                    else if (betalat < b)// om beloppet man får är mindre än priset att betala   
                    {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("fel, beloppet att betala är större än det erhållna beloppe!");
                    Console.ResetColor();
                    }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("fel, fel, du kan ha angett något som inte är en siffra eller en siffra med decimal, ange en heltals siffra!");
                    Console.ResetColor();
                }

            }

            Console.WriteLine(betalat);
            Console.WriteLine(total);
            betalat = int.Parse(Console.ReadLine());
   
        }
    }
}

