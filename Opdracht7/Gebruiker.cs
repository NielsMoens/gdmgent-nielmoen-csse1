using System;
using System.Security.Cryptography;
using System.Text;

namespace Opdracht07
{
	public class Gebruiker : Persoon
	{
		// Velden
		protected string gebruikersnaam;
		protected string wachtwoord;
		protected string login;

        // Properties
		public string Gebruikersnaam
		{
			get {return this.gebruikersnaam;}
		}

		public string Wachtwoord
		{
			get {return this.wachtwoord;}
		}

		public string Login{
			get {return this.login;}
		}

        // Constructor
		public Gebruiker (string naam, string voornaam, char geslacht) : base(naam, voornaam, geslacht)
		{
			this.gebruikersnaam = GenereerGebruikersnaam();
			this.login = GenereerLogin();
			this.wachtwoord = CreatePasswordHash(GenereerWachtwoord(), CreateSalt());
		}

		public Gebruiker (string naam, string voornaam, char geslacht, string gebruikersnaam, string wachtwoord, string login ) : base(naam, voornaam, geslacht)
		{
			this.gebruikersnaam = gebruikersnaam;
			this.wachtwoord = CreatePasswordHash(wachtwoord, CreateSalt());
			this.login = login;
		}

		//	Methodes
		public override void LogOutput()
		{
			Console.WriteLine(string.Format("Gebruikersnaam: {0}\nLogin: {1}\nWachtwoord: {2}", Gebruikersnaam, Login, Wachtwoord));
		}

		// GenereerWachtwoord
		protected Random randGen = new Random();
		 string GenereerWachtwoord()
		{
			string psw = "gebruiker";
			for (int i = 0; i < 100; i++) {
				psw += Convert.ToString(randGen.Next(100));
			}
			return psw + "rekiurbeg";
		}

		// GenereerGebruikersnaam
		private string GenereerGebruikersnaam()
		{
			return voornaam + Naam;
		}

		// GenereerLogin
		private string GenereerLogin()
		{
			return voornaam + Naam + "@arteveldehs.be";
		}
		
		// CREATE
		// Code copied from https://dotnetfiddle.net/yVeOVA
		// @Author: Kiran Unnikrishnan
		// thanks Jef voor deze bron te sharen ^^ 

		protected string CreatePasswordHash(string pwd, string salt)
		{
			string saltAndPwd = String.Concat(pwd, salt);
			string hashedPwd = GetHashString(saltAndPwd);
			var saltPosition = 5;
			hashedPwd = hashedPwd.Insert(saltPosition, salt);
			return hashedPwd;
		}

		protected string CreateSalt()
		{
			RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
			byte[] buff = new byte[10];
			rng.GetBytes(buff);
			var saltSize = 1;
			string salt = Convert.ToBase64String(buff);
			if (salt.Length > saltSize)
			{
				salt = salt.Substring(0, saltSize);
				return salt.ToUpper();
			}

			var saltChar = '^';
			salt = salt.PadRight(saltSize, saltChar);
			return salt.ToUpper();
		}

		protected string GetHashString(string password)
		{
			StringBuilder sb = new StringBuilder();
			foreach (byte b in GetHash(password))
				sb.Append(b.ToString("X2"));
			return sb.ToString();
		}

		protected byte[] GetHash(string password)
		{
			SHA384 sha = new SHA384CryptoServiceProvider();
			return sha.ComputeHash(Encoding.UTF8.GetBytes(password));
		}
	}
}