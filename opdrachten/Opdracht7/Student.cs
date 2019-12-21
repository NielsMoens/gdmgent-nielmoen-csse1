using System;

namespace Opdracht07
{
	public class Student : Gebruiker
	{

		// Constructor
		public Student(string naam, string voornaam, char geslacht) : base(naam, voornaam, geslacht)
		{
			this.gebruikersnaam = GenereerGebruikersnaam();
			this.login = GenereerLogin();
			this.wachtwoord = CreatePasswordHash(GenereerWachtwoordStudent(), CreateSalt());
		}

		//	Methodes
		//	GenereerGebruikersnaam
		private string GenereerGebruikersnaam()
		{
			string naam = "";
			if (voornaam.Length < 4){
                naam += voornaam.ToLower() + Naam.ToLower().Substring(0, 4);
            } 
			else {
                naam += voornaam.ToLower().Substring(0, 4) + Naam.ToLower().Substring(0, 4);
            }
            return naam;
		}

		// GenereerLogin
		private string GenereerLogin()
		{
			string naam = "";
			if (voornaam.Length < 4){
                naam += voornaam.ToLower() + Naam.ToLower().Substring(0, 4);
            } 
			else {
                naam += voornaam.ToLower().Substring(0, 4) + Naam.ToLower().Substring(0, 4);
            }
            return naam + "@student.arteveldehs.be";
		}

		// GenereerWachtwoordStudent
		private string GenereerWachtwoordStudent()
		{
			string psw = "Student";
			for (int i = 0; i < 100; i++)
			{
				psw += Convert.ToString(randGen.Next(100));
			}
			return psw + "tnedutd";
		}
	}
}