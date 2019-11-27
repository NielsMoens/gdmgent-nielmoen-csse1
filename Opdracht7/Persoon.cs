using System;

namespace Opdracht06
{
	public class Persoon
	{
        // Velden
		public string voornaam;
		private char geslacht;

        // Properties
		public char Geslacht
		{
			get	{ return geslacht; }
			set { geslacht = value; }
		}

		public string Naam
		{
			get;
			set;
		}
        // Constructor
		public Persoon(string naam, string voornaam, char geslacht)
		{
			Naam = naam;
			this.voornaam = voornaam;
			Geslacht = geslacht;
		}
        // Methods
		public void LogOutput()
		{
			Console.WriteLine(String.Format("Voornaam: {0}\nFamilienaam: {1}\nGeslacht: {2}", this.voornaam, Naam, Geslacht));
		}
	}
}