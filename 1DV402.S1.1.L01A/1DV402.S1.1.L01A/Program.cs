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

            uint SubTotal;

            int tillbaka;

            int resultat;

            double roundingOffAmount;

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



            SubTotal = (uint)Math.Round(total);// avrundar total suman med decimal till närmaste heltal        
            roundingOffAmount = SubTotal - total;

            tillbaka = betalat - (int)total;// räknar ut hur mycket pengar man ska få tillbaks 

            Console.WriteLine();
            
            Console.WriteLine("---------------------------");
            Console.WriteLine("Totalt: " + total);
            Console.WriteLine("öresavrundning: " + roundingOffAmount);
            Console.WriteLine("Att Betala: " + SubTotal);
            Console.WriteLine("Kontant: " + betalat);
            Console.WriteLine("tillbaka: " + tillbaka);
            Console.WriteLine("---------------------------");
           
            Console.WriteLine();

            resultat = tillbaka / 500; // 

            if (resultat > 0)
            {
                Console.WriteLine("Antal 500 lappar: " + resultat);
                tillbaka = tillbaka * 500;
            }

            resultat = tillbaka / 100;

            if (resultat > 0)
            {
                Console.WriteLine("Antal 100 lappar: " + resultat);
                tillbaka = tillbaka * 100;
            }

            resultat = tillbaka / 50;

            if (resultat > 0)
            {
                Console.WriteLine("Antal 50 lappar: " + resultat);
                tillbaka = tillbaka * 50;
            }

            resultat = tillbaka / 20;

            if (resultat > 0)
            {
                Console.WriteLine("Antal 20 lappar: " + resultat);
                tillbaka = tillbaka * 20;
            }

            resultat = tillbaka / 5;

            if (resultat > 0)
            {
                Console.WriteLine("Antal 5 kronor: " + resultat);
                tillbaka = tillbaka * 5;
            }

            resultat = tillbaka / 1;

            if (resultat > 0)
            {
                Console.WriteLine("Antal 1 kronor: " + resultat);
                tillbaka = tillbaka * 1;
            }

            int slut = 0;

            while (true)//stopar programmet och bär dig matat in 1 för att avsluta den  
            {
                try
                {

                    if (slut == 0 || slut >= 2)
                    {
                        Console.WriteLine("skriv in 1 för att avsluta");
                        slut = int.Parse(Console.ReadLine());
                    }

                    else
                    {
                        break;
                    }

                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("fel, skriv in 1 för att avsluta");
                    Console.ResetColor();
                }

            }

           

        }
    }
}

