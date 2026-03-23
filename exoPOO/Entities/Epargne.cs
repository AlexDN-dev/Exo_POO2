using exoPOO.Exceptions;

namespace exoPOO.Entities;

public class Epargne : Compte
{
    public DateTime DateDernierRetrait { get; private set; }
    
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
            throw new SoldeInsuffisantException("Le montant du retrait doit être positif.");
        }

        if (Solde - montant > Solde)
        {
            throw new SoldeInsuffisantException("Il n'y a pas assez d'argent pour retirer ce montant");
        }

        Solde -= montant;
        DateDernierRetrait = new DateTime().Date;
    }

    protected override double CalculInteret()
    {
        return (Solde / 100) * 4.5;
    }
}