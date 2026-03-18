namespace exoPOO.Entities;

public abstract class Compte
{
    public string? Numero { get; set; }
    public double Solde { get; protected set; }
    public Personne? Titulaire { get; set; }

    public abstract void Retrait(double montant);
    
    public void Depot(double montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine($"le montant doit etre supérieur à 0 ");
        }
        else
        {
            Solde += montant;
        }

    }
}