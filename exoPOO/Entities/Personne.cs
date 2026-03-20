namespace exoPOO.Entities;

public class Personne
{
    public string Lastname { get; init; }
    public string Firstname { get; init; }
    public DateOnly Birthday { get; init; }

    public override string ToString()
    {
        return ($"{Lastname} {Firstname} - {Birthday}");
    }
}