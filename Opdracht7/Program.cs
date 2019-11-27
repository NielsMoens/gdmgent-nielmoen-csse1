using System;
using Opdracht7;

namespace Opdracht06
{
    class Program
    {
        static void Main(string[] args)
        {
            Docent doc1 = new Docent("DeVogel", "Struisje", 'm');
            doc1.LogOutput();
            Console.Write("\n");

            Gebruiker gebr1 = new Gebruiker("DeMicroob", "Joop", 'm');
            gebr1.LogOutput();
            Console.Write("\n");

            Persoon pers1 = new Persoon("DeSpons", "Fons", 'm');
            pers1.LogOutput();
            Console.Write("\n");
            
            Student stu1 = new Student("DeKwal", "Vital", 'm');
            stu1.LogOutput();
            Console.Write("\n");

            //  Calculator add, substract, divide, multiply, modulus, faculteit, fibo
            var calculator = new Calculator(8, 3);
            Console.WriteLine(calculator + "\nfibonacci: ");
            Console.WriteLine(calculator.fibonacci());

            //  IBAN checker
            var Iban = new Iban("BE07 7390 1412 0066");
            Console.Write("\nThe IBAN: "+Iban);
            Console.WriteLine("\nCheck if valid control number: " + Iban.checkControlNumbers());
            Console.WriteLine("Check numbercount = 16: "+Iban.checkNumberOfCharcters());
            Console.Write("Switched Characters: ");
            Iban.switchCharacters();
            Console.WriteLine(Iban);
            Console.WriteLine("But is it really an IBAN?: "+Iban.isIban());
        }
    }
}
