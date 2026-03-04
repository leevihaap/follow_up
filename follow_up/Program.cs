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