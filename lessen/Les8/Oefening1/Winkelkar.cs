using System;    
    
namespace Oefening1
{
    public abstract class Winkelkar
    {
        public abstract void Ontgrendelen();
        public abstract void Rijden();
        public abstract void Rijden(int snelheid);
    }

    public class PlasticKar : Winkelkar
    {
        public PlasticKar()
        {
        }

        public override void Ontgrendelen()
        {
            
        }

        public override void Rijden()
        {

        }

        public override void Rijden(int snelh)
        {

        }
    }

    public class GroteKar : Winkelkar
    {
        public GroteKar()
        {
        }

        public override void Ontgrendelen()
        {
            throw new NotImplementedException();
        }

        public override void Rijden()
        {
            throw new NotImplementedException();
        }

        public override void Rijden(int snelh)
        {

        }
    }
}