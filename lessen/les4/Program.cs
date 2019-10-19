using System;

namespace les4
{
    class Program
    {
        int teller= 0; //dit is een globale var
        static void genFib(int lengte){
        // dit is een locale var
            Console.WriteLine("test " + lengte);
        }
        static void Main(string[] args)
        {
            int getal1 = 8;
            Console.WriteLine("Hello World!");
            genFib(getal1);
        }
    }
}
