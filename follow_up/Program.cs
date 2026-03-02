using System;
using System.Collections.Generic;

namespace OOPEsimerkki
{
	// RAJAPINTA
	public interface ILiikkuminen
	{
		void Liiku();
	}

	// PERUSLUOKKA (Inheritance base)
	public class Elain
	{
		public string Nimi { get; set; }

		public Elain(string nimi)
		{
			Nimi = nimi;
		}

		// Virtual mahdollistaa polymorfismin
		public virtual void Aani()
		{
			Console.WriteLine("Eläin ääntelee.");
		}
	}

	// PERINTÄ (Inheritance)
	public class Koira : Elain, ILiikkuminen
	{
		public Koira(string nimi) : base(nimi) { }

		public override void Aani()
		{
			Console.WriteLine($"{Nimi} sanoo: Hau hau!");
		}

		public void Liiku()
		{
			Console.WriteLine($"{Nimi} juoksee neljällä jalalla.");
		}
	}

	public class Lintu : Elain, ILiikkuminen
	{
		public Lintu(string nimi) : base(nimi) { }

		public override void Aani()
		{
			Console.WriteLine($"{Nimi} sanoo: Piip piip!");
		}

		public void Liiku()
		{
			Console.WriteLine($"{Nimi} lentää siivillään.");
		}
	}

	// PÄÄOHJELMA
	class Program
	{
		static void Main(string[] args)
		{
			// POLYMORFISMI:
			// Listassa on Elain-tyyppisiä olioita,
			// mutta ne käyttäytyvät oman luokkansa mukaisesti.
			List<Elain> elaimet = new List<Elain>
			{
				new Koira("Rekku"),
				new Lintu("Tintti")
			};

			Console.WriteLine("=== Äänet ===");
			foreach (Elain elain in elaimet)
			{
				elain.Aani(); // Kutsuu oikeaa override-metodia
			}

			Console.WriteLine("\n=== Liikkuminen ===");
			foreach (Elain elain in elaimet)
			{
				if (elain is ILiikkuminen liikkuva)
				{
					liikkuva.Liiku();
				}
			}

			Console.ReadLine();
		}
	}
}