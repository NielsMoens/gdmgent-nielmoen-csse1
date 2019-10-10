using System;

namespace oef2
{
    class Program
    {
        static void Main(string[] args)
        {
            //deel A
            // Console.WriteLine("deel A");
            // // LET OP examen vraag: niet dezelfde var als in je FOR loop
            // int i = 2; 
            // // Binnen een for maakt da ni uit deze i is geen gobale variable 
            // for (int i = 0; i < 10; i++)
            // {
                
            // }




            // part C my way
            int j,n;

            Console.Write("Input the number ");
            n= Convert.ToInt32(Console.ReadLine());   
            Console.Write("\n");
            for(j=1;j<=10;j++)
            {
                Console.Write("{0} X {1} = {2} \n",j,n,n*j);
            }

            

        }
    }
}
