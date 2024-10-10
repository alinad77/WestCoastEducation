namespace WestCoastEducation;

public class Person
{
    public string? Förnamn { get; set; }
    public string? Efternamn { get; set; }
    public string? Telefon { get; set; }
    public string? Adress { get; set; }
    public string? Postnummer { get; set; }
    public string? Ort { get; set; }

    public override string ToString()
    {
        return $"Förnamn: {Förnamn}, Efternamn: {Efternamn}, Telefon: {Telefon}, Adress: {Adress}, Postnummer: {Postnummer}, Ort: {Ort}";
    }
}
