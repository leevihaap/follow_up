
public class Elintarvike : Tuote  // perintärakenne
{
	public DateTime ParastaEnnen { get; set; }

	public Elintarvike(string nimi, double hinta, DateTime parastaEnnen)
		: base(nimi, hinta)
	{
		ParastaEnnen = parastaEnnen;
	}

	public override void NaytaTiedot()
	{
		Console.WriteLine($"Elintarvike: {Nimi}, Hinta: {Hinta}€, Parasta ennen: {ParastaEnnen.ToShortDateString()}");
	}
}