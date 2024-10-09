namespace WestCoastEducation;

public class Studerande
{
    public string Förnamn { get; set; }
    public string Efternamn { get; set; }
    public string Telefon { get; set; }
    public string Adress { get; set; }
    public string Postnummer { get; set; }
    public string Ort { get; set; }
    public List<Kurs> KursLista { get; set; }

    public Studerande()
    {
        KursLista = new List<Kurs>();
    }

    public override string ToString()
    {
        return $"Förnamn: {Förnamn}, Efternamn: {Efternamn}, Telefon: {Telefon}, Adress: {Adress}, Postnummer: {Postnummer}, Ort: {Ort} ";
    }

    public void AddKurs(Kurs kurs)
    {
        KursLista.Add(kurs);
        kurs.AddStuderande(this);
    }

    public void RemoveKurs(Kurs kurs)
    {
        KursLista.Remove(kurs);
        kurs.RemoveStuderande(this);
    }

    public List<Kurs> GetKurser()
    {
        return KursLista;
    }
}
