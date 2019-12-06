using System;

namespace Oefening1
{
    public class Dier
    {
        public Dier(){}
        public void VoedingGeven()
        {
            Console.WriteLine("Basisklasse Dier : VoedingGeven");
        }
    }

    public class Hond : Dier
    {
        public Hond(){}
        public void VoedingGeven()
        {
            Console.WriteLine("Subklasse Hond : VoedingGeven");
        }
    }

    public class Dier1
    {
        public Dier1(){}
        public virtual void VoedingGeven()
        {
            Console.WriteLine("Basisklasse Dier1 : VoedingGeven");
        }
    }

    public class Hond1 : Dier1
    {
        public Hond1(){}
        public override void VoedingGeven()
        {
            Console.WriteLine("Subklasse Hond1 : VoedingGeven");
        }
    }

     public class Dier2
    {
        public Dier2(){}
        public void VoedingGeven()
        {
            Console.WriteLine("Basisklasse Dier2 : VoedingGeven");
        }
    }

    public class Hond2 : Dier2
    {
        public Hond2(){}
        public void VoedingGeven()
        {
            Console.WriteLine("Subklasse Hond2 : VoedingGeven");
        }
    }

    public class Dier3
    {
        public Dier3(){}
        public virtual void VoedingGeven()
        {
            Console.WriteLine("Basisklasse Dier3 : VoedingGeven");
        }
    }

    public class Hond3 : Dier3
    {
        public Hond3(){}
        public override void VoedingGeven()
        {
            base.VoedingGeven();
            Console.WriteLine("Subklasse Hond3 : VoedingGeven");
        }
    }
}