using System;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculator
            decimal getal = 7;
            decimal verhoog = 1;
            decimal verlaag = 1;
            var calculator = new Calculator(8, 3);
            Console.WriteLine(calculator);
            increase(getal, verhoog);
            decrease(getal, verlaag);

            // IBAN checker
            var Iban = new Iban("BE07 7390 1412 0066");
            Console.Write("\nThe IBAN: "+Iban);
            Console.WriteLine("\nCheck if valid control number: " + Iban.checkControlNumbers());
            Console.WriteLine("Check numbercount = 16: "+Iban.checkNumberOfCharcters());
            Console.Write("Switched Characters: ");
            Iban.switchCharacters();
            Console.WriteLine(Iban);
            Console.WriteLine("But is it really an IBAN?: "+Iban.isIban());
        }

        //  verhoog
        static decimal increase ( decimal num, decimal plusOne){
            decimal result = num + plusOne;
            Console.WriteLine("Increase: " + result);
            return num + plusOne;
        }

        //  verlaag
        static decimal decrease ( decimal num, decimal minOne){
            decimal result = num - minOne;
            Console.WriteLine("Decrease: " + result);
            return num + minOne;
        }
    }
}
