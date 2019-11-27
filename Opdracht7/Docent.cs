using System;

namespace Opdracht06
{
	public class Docent : Gebruiker
	{
		public Docent(string naam, string voornaam, char geslacht) : base (naam, voornaam, geslacht)
		{
			this.gebruikersnaam = GenereerGebruikersnaam();
			this.login = GenereerLogin();
			this.wachtwoord = CreatePasswordHash(GenereerWachtwoord(), CreateSalt());
		}

		private string GenereerGebruikersnaam()
		{
			string fullName = "";
			if (voornaam.Length < 4){
                fullName += voornaam.ToLower() + Naam.ToLower().Substring(0, 2);
            } else {
                fullName += voornaam.ToLower().Substring(0, 4) + Naam.ToLower().Substring(0, 2);
            }
            return fullName;
		}

		private string GenereerLogin()
		{
			string fullName = "";
			if (voornaam.Length < 4){
                fullName += voornaam.ToLower() + Naam.ToLower().Substring(0, 2);
            } else {
                fullName += voornaam.ToLower().Substring(0, 4) + Naam.ToLower().Substring(0, 2);
            }
            return fullName + "@arteveldehs.be";
		}
		private string GenereerWachtwoord()
		{
			string psw = "docent";
			for (int i = 0; i < 100; i++)
			{
				psw += Convert.ToString(randGen.Next(100));
			}
			return psw + "tnecod";
		}
	}
}