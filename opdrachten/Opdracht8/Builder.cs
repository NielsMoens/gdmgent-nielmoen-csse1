using System;
using System.Collections.Generic;

namespace Opdracht8
{
     // The Builder interface specifies methods for creating the different parts
    // of the Krant objects.
    public interface IBuilder
    {
        void secties();
        void artikels();
        void reclame();
    }
    
    public class Krant
    {
        private List<object> _content = new List<object>();

        public void Add(string part)
        {
            this._content.Add(part);
        }
        
        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._content.Count; i++)
            {
                str += this._content[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Krant parts: " + str + "\n";
        }
    }
    
    // The Director is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration. Strictly speaking, the Director class is
    // optional, since the client can control builders directly.
    public class Director
    {
        private IBuilder _builder;
         
        public IBuilder Builder
        {
            set { _builder = value; } 
        }
        
        // The Director can construct several product variations using the same
        // building steps.
        public void buildMinimalViableProduct()
        {
            this._builder.secties();
        }
    
        public void buildFullFeaturedProduct()
        {
            this._builder.secties();
            this._builder.artikels();
            this._builder.reclame();
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            // The client code creates a builder object, passes it to the
            // director and then initiates the construction process. The end
            // result is retrieved from the builder object.
            var director = new Director();
            var builder = new ConcreteBuilderMetro();
            director.Builder = builder;

            Console.WriteLine("full featured krantMetro:");
            director.buildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());


            var builder2 = new ConcreteBuilderDestandaard();
            director.Builder = builder2;

            Console.WriteLine("full featured krantStandaard:");
            director.buildFullFeaturedProduct();
            Console.WriteLine(builder2.GetProduct().ListParts());

        }
    }
}