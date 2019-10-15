using System;

namespace oef5
{
    class Program
    {
        static void Main(string[] args){
            // FIBONACCI
            // n -> lengte reeks
            int firstVal=0 , thrVal = 0;
            int secVal = 1;
            Console.WriteLine("=================================\n DE RIJ VAN FIBONACCI\n=================================");
            Console.Write("Input the Row number: ");
            int loop = Convert.ToInt32(Console.ReadLine());
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
    }
}
