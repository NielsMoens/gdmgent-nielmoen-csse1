using System;

namespace Oefeningen
{
    class Program
    {
        static void genFac(){
        // dit is een locale var
            
        }
        static void genFib(int gen){
        // dit is een locale var
            Console.WriteLine("test " + lengte);
            long firstVal=0 , thrVal = 0; 
            long secVal = 1;
            Console.WriteLine("=================================\n DE RIJ VAN FIBONACCI\n=================================");
            Console.Write("Input the Row number: ");
            long loop = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("\n");
            Console.WriteLine(firstVal);
            Console.WriteLine(secVal);
            for (int i = 2; i < loop; i++){
                thrVal = firstVal + secVal;
                firstVal = secVal;
                secVal = thrVal;
                Console.WriteLine(thrVal);
                }
                
        }
        static void Main(string[] args)
        {
            genFac();
            Console.WriteLine("Hello World!");
        }
    }
}
