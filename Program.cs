
class Program
{
	static void Main(string[] args)
	{
		List<Tuote> tuotteet = new List<Tuote>();  // Polymorfismi

		tuotteet.Add(new Tuote("Tietokone", 799));
		tuotteet.Add(new Tuote("Hiiri", 60));
		tuotteet.Add(new Elintarvike("Leipä", 1.20, DateTime.Now.AddDays(3)));
		tuotteet.Add(new Elintarvike("Maito", 2.50, DateTime.Now.AddDays(7)));

		foreach (Tuote t in tuotteet)
		{
			t.NaytaTiedot();   // Polymorfinen kutsu
		}
	}
}