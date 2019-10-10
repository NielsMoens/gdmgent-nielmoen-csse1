using System;

namespace les3
{
    class Program
    {
        static void Main(string[] args)
        {
            // EASY WAY 
            // int getal = 5;
            // if (getal < 8){
            //     getal ++;
            //     Console.WriteLine("dit is het getal " + getal);
            // }
            // else if (getal > 6)
            // {
            //     getal ++;
            //      Console.WriteLine("LOL *" + getal);
            // } 
            // else {
            //     Console.WriteLine("LEL");
            // }

            // ONE LINER YEET
            // int getal; 
            // getal = 5; // initialisatie van var getal => waarde 5
            // Console.WriteLine("geef keer een getalleken tss 0-10?");
            // getal = Convert.ToInt32(Console.ReadLine());
            // if(getal < 8 || getal > 6 || getal >=7){
            //     getal ++;
            //     Console.WriteLine("dit is het getal " + getal);
            //     Console.WriteLine("test");
            // }
            // int getal; 
            // getal = 5;
            // getal = Convert.ToInt32(Console.ReadLine());

            // if(getal < 8 ){
            //     Console.WriteLine(" de waarde van het getal : "+ getal);
            // }
            //     Console.WriteLine("test");

            // THE SWITCH WAY (niet echt handig in dit voorbeeld)
            // int getal; 
            // getal = 5; // initialisatie van var getal => waarde 5
            // Console.WriteLine("geef keer een getalleken tss 0-10?");
            // getal = Convert.ToInt32(Console.ReadLine());
            // switch (getal)
            // {
            //     case 7:
            //         Console.WriteLine("het getal is (case7): "+ getal);
            //         break;
            //     default:
            //         Console.WriteLine("het getal is (case7): "+ getal);
            //         break;
            // }

            //FOR LOOPS     
            int teller; 
            teller = 5; // initialisatie van var getal => waarde 5
            for (int i = 0; i < teller; )
            {
                Console.WriteLine(i);
            }
            
            // 
        }
    }
}
