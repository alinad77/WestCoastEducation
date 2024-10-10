namespace WestCoastEducation;

public class Kurs
{
    public int Kursnummer { get; set; }
    public string Title { get; set; } = string.Empty; // Säkerställer att Title aldrig är null
    public int Längd { get; set; } // antal veckor eller dagar
    public DateTime Startdatum { get; set; }
    public DateTime Slutdatum { get; set; }
    public bool Klassrumsbunden { get; set; } // true om kursen är klassrumsbunden, false om den är på distans
    public List<Studerande> StuderandeLista { get; set; }

    public Kurs()
    {
        StuderandeLista = new List<Studerande>();
    }

    public override string ToString()
    {
        return $"Kursnummer: {Kursnummer}, Title: {Title}, Längd: {Längd} veckor, Startdatum: {Startdatum.ToShortDateString()}, Slutdatum: {Slutdatum.ToShortDateString()}, Klassrumsbunden: {Klassrumsbunden}";
    }

    public void AddStuderande(Studerande studerande)
    {
        if (!StuderandeLista.Contains(studerande))
        {
            StuderandeLista.Add(studerande);
        }
    }

    public void RemoveStuderande(Studerande studerande)
    {
        StuderandeLista.Remove(studerande);
    }

    public List<Studerande> GetStuderandeLista()
    {
        return StuderandeLista;
    }
}
