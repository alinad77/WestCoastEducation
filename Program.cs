using System.Net.Sockets;

namespace WestCoastEducation;

class Program
{
    static void Main(string[] args)
    {
        // Skapa en ny kurs
        Kurs kurs = new Kurs
        {
            Kursnummer = 1,
            Title = "Programmering",
            Längd = 10,
            Startdatum = DateTime.Now,
            Slutdatum = DateTime.Now.AddDays(10),
            Klassrumsbunden = true,
        };

        // Skapa en ny studerande
        Studerande studerande = new Studerande
        {
            Förnamn = "Nome",
            Efternamn = "Abdigadir",
            Telefon = "0701234567",
            Adress = "Kävlinge Bygata 1",
            Postnummer = "12345",
            Ort = "Malmö",
        };

        // Lägg till studerande till kurs
        kurs.AddStuderande(studerande);

        // Visa kursinformation
        Console.WriteLine(kurs.ToString());

        // Visa studerandeinformation
        Console.WriteLine(studerande.ToString());

        // Lista kurser
        List<Kurs> kurser = new List<Kurs> { kurs };
        foreach (var k in kurser)
        {
            Console.WriteLine(k.ToString());
        }

        // Lista studenter
        List<Studerande> studenter = new List<Studerande> { studerande };
        foreach (var s in studenter)
        {
            Console.WriteLine(s.ToString());
        }
    }
}
