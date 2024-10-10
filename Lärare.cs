namespace WestCoastEducation;

public class Lärare : Studerande
{
    public required string Kunskapsområde { get; set; }
    public List<Kurs> AnsvarigaKurser { get; set; }

    public Lärare()
    {
        AnsvarigaKurser = new List<Kurs>();
    }

    public override string ToString()
    {
        return base.ToString() + $" Kunskapsområde: {Kunskapsområde}";
    }

    public new void AddKurs(Kurs kurs)
    {
        if (AnsvarigaKurser.Contains(kurs))
        {
            AnsvarigaKurser.Add(kurs);
        }
    }

    public new void RemoveKurs(Kurs kurs)
    {
        if (AnsvarigaKurser.Contains(kurs))
        {
            AnsvarigaKurser.Remove(kurs);
        }
    }

    public List<Kurs> GetAnsvarigaKurser()
    {
        return AnsvarigaKurser;
    }
}
