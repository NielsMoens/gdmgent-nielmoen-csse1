using System;

namespace Opdracht07
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
        }
    }
}
