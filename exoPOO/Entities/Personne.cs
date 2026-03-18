namespace exoPOO.Entities;

public class Personne
{
    public string Lastname { get; set; }
    public string Firstname { get; set; }
    public DateOnly Birthday { get; set; }

    public override string ToString()
    {
        return ($"{Lastname} {Firstname} - {Birthday}");
    }
}