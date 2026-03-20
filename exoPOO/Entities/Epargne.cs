namespace exoPOO.Entities;

public class Epargne : Compte
{
    private DateTime DateDernierRetrait { get; set; }
    
    public Epargne(string numero, Personne titulaire, DateTime dateDernierRetrait) : base(numero, titulaire)
    {
        DateDernierRetrait = dateDernierRetrait;
    }

    public Epargne(string numero, Personne titulaire, double solde, DateTime dateDernierRetrait) : base(numero, titulaire, solde)
    {
        DateDernierRetrait = dateDernierRetrait;
    }
    
    public override void Retrait(double montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine($"le montant doit etre supérieur à 0 ");
            return;
        }

        if (Solde - montant > Solde)
        {
            Console.WriteLine("Pas assez d'argent pour retirer ce montant");
            return;
        }

        Solde -= montant;
        DateDernierRetrait = new DateTime().Date;
    }

    protected override double CalculInteret()
    {
        return (Solde / 100) * 4.5;
    }
}