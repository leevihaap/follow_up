

public class Tuote : IKasiteltava  // Rajapinnan toteutus
{
	public string Nimi { get; set; }
	public double Hinta { get; set; }

	public Tuote(string nimi, double hinta)
	{
		Nimi = nimi;
		Hinta = hinta;
	}

	public virtual void NaytaTiedot()
	{
		Console.WriteLine($"Tuote: {Nimi}, Hinta: {Hinta}€");
	}
}