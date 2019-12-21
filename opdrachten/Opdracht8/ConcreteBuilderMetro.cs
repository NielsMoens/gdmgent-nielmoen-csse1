using System;
using System.Collections.Generic;

namespace Opdracht8
{
public class ConcreteBuilderMetro : IBuilder
    {
        private Krant _krant = new Krant();
        
        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public ConcreteBuilderMetro()
        {
            this.Reset();
        }
                
        public void Reset()
        {
            this._krant = new Krant();
        }
        
        // All production steps work with the same product instance.
       public void secties()
        {
            this._krant.Add("Weer\n");
            this._krant.Add("Economie\n");
            this._krant.Add("Tv-gids\n");
            this._krant.Add("Binneland\n");
            this._krant.Add("Buitenland\n");
        }
        
        public void artikels()
        {
            this._krant.Add("MediaArtikel\n");
            this._krant.Add("NieuwsArtikel\n");
            this._krant.Add("TechnologieArtikel\n");
        }
        
        public void reclame()
        {
            this._krant.Add("ad1: MediaMark -> JAWADE DADE\n");
            this._krant.Add("ad2: Van den borre ad\n");
            this._krant.Add("ad3: Proximus \n");
        }
        
        // Concrete Builders are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Builder interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
        public Krant GetProduct()
        {
            Krant result = this._krant;

            this.Reset();

            return result;
        }
    }
}