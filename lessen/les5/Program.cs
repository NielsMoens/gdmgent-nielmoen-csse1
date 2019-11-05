using System;
using System.Threading;

namespace Opdracht4
{
    class Program
    {
        //zit er iets in de colectie
        // /als er iets in zit geef mijn het eerste argument
        // is da student of docent
        // is goe gaje verder ist 
        static void Main(string[] args)
        {
            // Log(Product(2,3));
            // GenereerLottoGetallen();
            // GenereerEuroMillionsGetallen();
            GenereerAccount();
            try
            {
                Console.WriteLine(args.Length);
                Console.WriteLine(args[0]);
            }
            catch(System.Exception)
            {
                Console.WriteLine();
            }
            catch(System.IndexOutOfRangeException)
            {
                Console.WriteLine("de collectie is leeg");
            }
        }

        static int Som(int getal1, int getal2)
        {
            return getal1 + getal2;
        }

        static int Verschil(int getal1, int getal2)
        {
            return getal1 - getal2;
        }

        // ++ voor variabele
        static int Verhogen(int getal)
        {
            return ++getal;
        }

        // -- voor variabele
        static int Verlagen(int getal)
        {
            return --getal;
        }

        static int Product(int getal1, int getal2)
        {
            return getal1 * getal2;
        }

        static int Quotient(int getal1, int getal2)
        {
            return getal1 / getal2;
        }

        static int GenereerWillekeurigGetal(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }

        static void GenereerLottoGetallen()
        {
            Console.WriteLine("Lottotrekking:");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(GenereerWillekeurigGetal(1,45) + " ");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\n");
        }

        // euromillions
        static void GenereerEuroMillionsGetallen()
        {
            Console.WriteLine("Euromillions:");
            for (int i=0; i < 5; i++)
            {
                Console.Write(GenereerWillekeurigGetal(1,50) + " ");
                Thread.Sleep(1000);
            }

            Console.WriteLine("\nStars:");
            for (int j=0; j < 2; j++)
            {
                Console.Write(GenereerWillekeurigGetal(1,12) + " ");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\n");            
        }
        static string GenereerAccount(string voornaam, string achternaam)
        {
            return String.Format("De acc van {0} {1} is {2}",
            voornaam, achternaam,
            GenereerString(voornaam.ToLower(), 4) +
            GenereerString(achternaam.ToLower(), 4));
        }
        static string GenereerString(string input, int lengte)
        {
            return input.Substring(0, lengte);
        }

        //shorthand Console.Writeline();
        static void Log(int output) => Console.WriteLine(output.ToString());
    }
}