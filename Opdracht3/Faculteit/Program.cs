using System;

namespace oef4
{
    class Program
    {
        static void Main(string[] args)
        {
            // FACULTEIT
            //n -> uitlezen
            // spast proefen van variablen 
            // door het gebruik van long i.p.v.  
            long n,j;
            Console.WriteLine("=================================\n FACULTEIT\n=================================");
            Console.Write("Input the number: ");
            n= Convert.ToInt32(Console.ReadLine());   
            Console.Write("\n");
            long facul=1;
            if(n > 0){
                for(j=1;j<=n;j++)
                {
                facul= facul*j;
                }
                Console.WriteLine(facul);
            }else{
                Console.WriteLine("result = "+ facul);
            }
            
        }
    }
}
