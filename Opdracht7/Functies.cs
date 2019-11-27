using System;
using System.Threading;

namespace Opdracht07
{
    public class Functies : Logging
    {
        //  som
        public static decimal add(decimal number1, decimal number2) {
            return number1 + number2;
        }

        //  verschil
        public static decimal subtract(decimal number1, decimal number2) {
            return number1 - number2;
        }
        
        //  quotiënt
        public static decimal divide(decimal number1, decimal number2) {
            if (number2 == 0) {
                throw new ArgumentException("Cannot divide by zero!!!");
            }
            return Math.Round(number1 / number2, 2);
        }

        //  product
        public static decimal multiply(decimal number1, decimal number2) {
            return number1 * number2;
        }

        // modulus
        public static decimal modulus(decimal number1, decimal number2){
            return number1 % number2;
        }
        
        // faculteit
        public static string faculteit(decimal number){
        long j;
            long facul=1;
            for(j=1;j<=number; j++)
            {
            facul= facul*j;
            }
            string magic = facul.ToString();            
            return magic;
        }

        // fibonacci
        public static string fibonacci(decimal number){
            int i;
            decimal firstVal=0 , thrVal = 0; 
            decimal secVal = 1;
            decimal loop = number; 
            Console.WriteLine(firstVal.ToString());
            Console.WriteLine(secVal.ToString());
            for ( i = 2; i < loop; i++){
                thrVal = firstVal + secVal;
                firstVal = secVal;
                secVal = thrVal;
                Console.WriteLine(thrVal);
            }
            return null;
        }
        
        // check Control Numbers
        public static Boolean checkControlNumbers(string ibanNumber) {
            int controlNumber = Int32.Parse(ibanNumber.Substring(2, 2));
            return (ibanNumber.Substring(0, 2) == "BE" && controlNumber >= 2 && controlNumber <= 98);
        }

        // check if number of characters = 16
        public static Boolean checkNumberOfCharcters(string ibanNumber) {
            return ibanNumber.Length == 16;
        }

        // switch controle numbers and replace them with hex numbers
        public static string switchCharacters(string ibanNumber) {
            var controlNumbers = ibanNumber.Substring(0, 4);
            return (ibanNumber.Replace(controlNumbers, "") + controlNumbers).Replace("BE", "1114");
        }

        // check modulus 97 = 1
        public static Boolean isIban(string ibanNumber) {
            var number = Int64.Parse(ibanNumber);
            return (number % 97 == 1);
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
        public override void LogOutput()
		{
        
		}
    }
}