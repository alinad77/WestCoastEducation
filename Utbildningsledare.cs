namespace WestCoastEducation;

public class Utbildningsledare : Lärare
{
    public DateTime Anställningsdatum { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", Anställningsdatum: {Anställningsdatum}";
    }
}
