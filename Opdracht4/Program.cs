using System;

namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator(8, 3);

            Console.WriteLine(calculator);        
        }

        // public static void Add(int number01, int number02)
        // {
        //     Console.WriteLine(number01+number02);
        // }
        // public static void Subtract(int number01, int number02)
        // {
        //     Console.WriteLine(number01-number02);
        // }
        // public static void Multiply(int number01, int number02)
        // {
        //     Console.WriteLine(number01*number02);
        // }
        // public static void Divide(double number01, double number02)
        // {
        //     Console.WriteLine(number01/number02);
        // }
                static int GenereerWillekeurigGetal(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }

        // static void GenereerLottoGetallen()
        // {
        //     Console.WriteLine("Lottotrekking:");
        //     for (int i = 0; i < 6; i++)
        //     {
        //         Console.Write(GenereerWillekeurigGetal(1,45) + " ");
        //         Thread.Sleep(1000);
        //     }
        //     Console.WriteLine("\n");
        // }

        // // euromillions
        // static void GenereerEuroMillionsGetallen()
        // {
        //     Console.WriteLine("Euromillions:");
        //     for (int i=0; i < 5; i++)
        //     {
        //         Console.Write(GenereerWillekeurigGetal(1,50) + " ");
        //         Thread.Sleep(1000);
        //     }

        //     Console.WriteLine("\nStars:");
        //     for (int j=0; j < 2; j++)
        //     {
        //         Console.Write(GenereerWillekeurigGetal(1,12) + " ");
        //         Thread.Sleep(1000);
        //     }
        //     Console.WriteLine("\n");            
        // }
        // static string GenereerAccount(string voornaam, string achternaam)
        // {
        //     return String.Format("De acc van {0} {1} is {2}",
        //     voornaam, achternaam,
        //     GenereerString(voornaam.ToLower(), 4) +
        //     GenereerString(achternaam.ToLower(), 4));
        // }

    }
}

