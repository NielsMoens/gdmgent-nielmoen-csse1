using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dier d = new Dier();
            d.VoedingGeven();
            Hond h = new Hond();
            h.VoedingGeven();

             Dier1 d1 = new Dier1();
            d1.VoedingGeven();
            Hond1 h1 = new Hond1();
            h1.VoedingGeven();

            Dier2 d2 = new Dier2();
            d2.VoedingGeven();
            Hond2 h2 = new Hond2();
            h2.VoedingGeven();

            Dier2 dier = new Dier2(); 
            dier.VoedingGeven(); 
            dier = new Hond2();
            dier.VoedingGeven();

            Dier dier1 = new Dier(); 
            dier1.VoedingGeven(); 
            dier1 = new Hond();
            dier1.VoedingGeven();

            Dier1 dier2 = new Dier1(); 
            dier2.VoedingGeven(); 
            dier2 = new Hond1();
            dier2.VoedingGeven();

            Dier3 dier3 = new Dier3();
            dier3.VoedingGeven(); 
            dier3 = new Hond3();
            dier3.VoedingGeven();

            Console.WriteLine(Functies.GenereerGetal());


/*
           

            

            

            Dier dier1 = new Dier(); 
            dier1.VoedingGeven(); 
            dier1 = new Hond();
            dier1.VoedingGeven();

            Dier1 dier2 = new Dier1(); 
            dier2.VoedingGeven(); 
            dier2 = new Hond1();
            dier2.VoedingGeven();

            Dier3 dier3 = new Dier3();
            dier3.VoedingGeven(); 
            dier3 = new Hond3();
            dier3.VoedingGeven();
             */
        }
    }
}
