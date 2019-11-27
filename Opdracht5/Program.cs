using System;
using System.Threading;

namespace Opdracht5
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Calculator add, substract, divide, multiply, modulus, faculteit, fibo
            var calculator = new Calculator(8, 3);
            Console.WriteLine(calculator + "\nfibonacci: ");
            Console.WriteLine(calculator.fibonacci());

            // verhoog verlaag
            decimal getal = 7;
            decimal verhoog = 1;
            decimal verlaag = 1;
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
            Console.WriteLine("A randomNumber with range: " + randomNumGen2());

            //  lotto
            lotto();

            //  euromillions
            euroMillions();

            // acc genarator
            try
            {
                string status = args[0];
                string prename = args[1];
                string name = args[2]; 

                Console.Write("\n"+GenAcc(status, prename, name));
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("\nEMPTY!!!!!!");
            }
            catch(System.Exception)
            {
                Console.WriteLine("AHZO NEN ERROR PEEKEN! \nAHZO EEN KLET");
            }
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
            try
            {
                Random rng = new Random();
                return rng.Next(val1, val2);
            }
            catch(System.Exception){
                return 0;
            }
        }
        static int randomNumGen2(){
            try
            {
                Random rng = new Random();
                return rng.Next();
            }
            catch{
                return 0;
            }
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

        // account genarator
        static string GenAcc(string status, string prename, string name){
            string email= "";

            if (status == "docent"){
                email = GenString(prename, 4) + GenString(name, 2) + "@artevelde.be";
            }
            else if (status == "student"){
                email = GenString(prename, 4) + GenString(name, 4) + "@student.artevelde.be";
            }
            return email;
        }

        static string GenString(string input, int length)
        {
            return input.Substring(0, input.Length < length ? input.Length : length).ToLower();
        }
    }
}
        
