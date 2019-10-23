using System;

namespace Opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator(8, 3);

            /*Console.WriteLine(calculator.add());
            Console.WriteLine(calculator.subtract());
            Console.WriteLine(calculator.divide());
            Console.WriteLine(calculator.multiply());*/

            Console.WriteLine(calculator);
            
            /*Multiply(8, 3);
            Divide(8, 3);
            Add(8, 3);
            Subtract(8, 3); */           
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
    }
}
