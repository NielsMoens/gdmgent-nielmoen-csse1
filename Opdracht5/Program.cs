using System;
using System.Threading;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Calculator
            decimal getal = 7;
            decimal verhoog = 1;
            decimal verlaag = 1;
            var calculator = new Calculator(8, 3);
            Console.WriteLine(calculator);
            increase(getal, verhoog);
            decrease(getal, verlaag);

            //  IBAN checker
            var Iban = new Iban("BE07 7390 1412 0066");
            Console.Write("\nThe IBAN: "+Iban);
            Console.WriteLine("\nCheck if valid control number: " + Iban.checkControlNumbers());
            Console.WriteLine("Check numbercount = 16: "+Iban.checkNumberOfCharcters());
            Console.Write("Switched Characters: ");
            Iban.switchCharacters();
            Console.WriteLine(Iban);
            Console.WriteLine("But is it really an IBAN?: "+Iban.isIban());
            
            //  randomNumberGenarator
            Console.WriteLine("A randomNumber: " + randomNumGen(1, 45));

            //  lotto
            lotto();

            //  euromillions
            euroMillions();
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

        // randomnumber
        static int randomNumGen(int val1, int val2){
            Random rng = new Random();
            return rng.Next(val1, val2);
        }

        // lotto
        static void lotto(){
            Console.Write("\nThe winning lotto numbers are: ");
            int[] arr = new int[6];
            for (int i = 0; i < 6; i++)
            {
                int randomNumber = randomNumGen(1,45);
                arr[i] = Convert.ToInt32(randomNumber);
                Console.Write(randomNumber + " ");
                Thread.Sleep(1000);
            }

            Console.WriteLine("\nThe saved winnningNumbers: ");
            for (int o = 0; o < 6; o++)
            {
                Console.Write(arr[o] + " ");
            }
        }

        // euroMillions
        static void euroMillions(){
            Console.Write("\nThe winning euroNumbers are: ");
            for (int i = 0; i < 6; i++)
            {
                int randomNumber = randomNumGen(1, 50);
                Console.Write(randomNumber + " ");
                Thread.Sleep(2000);
            }

            Console.WriteLine("\nStars: ");
            for (int o = 0; o < 2; o++)
            {
                int randomNumber = randomNumGen(1, 12);
                Console.Write(randomNumber + " ");
                Thread.Sleep(2000);
            }
        }

    }
}
