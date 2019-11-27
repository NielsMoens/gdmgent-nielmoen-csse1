using System;

namespace oefening1
{
    public class Gebruiker : Persoon1
    {
        // velden
        private string gebruikersnaam;
        private string wachtwoord;
        private string login;
        // properties
        public string gebruikersnaam
        {
            get;
            set;
        }
        //constructor
        public Gebruiker (string voornaam, string naam, string geslacht, string geboortedatum)
        {
            this.voornaam = voornaam;
            this.naam = naam;
            this.geslacht = geslacht;
            this.geboortedatum = geboortedatum;
        }
        
        // mehthods
        public student (string voornaam, string naam, string geslacht, string geboortedatum)
        {
            
        }
        
        public docent (string voornaam, string naam, string geslacht, string geboortedatum)
        {

        }
        



    }
}
