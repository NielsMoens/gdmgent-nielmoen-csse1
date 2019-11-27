namespace oef1_classe_ 
{
    public class Persoon1
    {
        // velden
        public string voornaam;
        private char geslacht;

        // properties
        public char Geslacht
        {
                get;
                set;
        }
        public string Naam 
        {
            get;
            set;
        }

        //constructor

        public  Persoon1()
        {

        }
        public  Persoon1(string naam, string voornaam)
        {

        }
        public  Persoon1(string naam, string voornaam, char geslacht)
        {
                Naam = Naam;
                this.voornaam = voornaam;
                Geslacht = geslacht;

        }

        // mehthods


    }
}