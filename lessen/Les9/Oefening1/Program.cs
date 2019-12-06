using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Hieronder gaan we via de methode WriteLine van de klasse Console
                over tot het schrijven van een tekstregel in de Console.
             */
            Console.WriteLine("Hello World!");
            
        }

        /// <summary>
        /// To write a string to the console.
        /// </summary>
        static void WriteLog(string input)
        {
            // TODO: Commentaar toevoegen.
            Console.WriteLine("Hello World!");
        }
    }

    public class D : A
    {
        // NOTE: Nog verder uitwerken...
        public override void DoWork(int i)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public abstract class A
    {
        public abstract void DoWork(int i);
        public int Amount
        {
            get;
            set;
        }
        public String WhichAmout()
        {
            return "Current amount is " + this.Amount;
        }
    }

    public abstract class B
    {
        public int SpecialAmount
        {
            get;
            set;
        }
    }

    public interface IC
    {
        bool accountActive(string a);

        void Logging(string input)
        {
            Console.WriteLine(input);
        }
    }
}