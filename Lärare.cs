namespace WestCoastEducation;

public class Lärare : Studerande
{
    public string Kunskapsområde { get; set; }
    public List<Kurs> AnsvarigaKurser { get; set; }

    public Lärare()
    {
        AnsvarigaKurser = new List<Kurs>();
    }

    public override string ToString()
    {
        return base.ToString() + $" Kunskapsområde: {Kunskapsområde}";
    }

    public void AddKurs(Kurs kurs)
    {
        AnsvarigaKurser.Add(kurs);
    }

    public void RemoveKurs(Kurs kurs)
    {
        AnsvarigaKurser.Remove(kurs);
    }

    public List<Kurs> GetAnsvarigaKurser()
    {
        return AnsvarigaKurser;
    }
}
