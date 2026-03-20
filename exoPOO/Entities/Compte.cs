using exoPOO.Interfaces;

namespace exoPOO.Entities;

public abstract class Compte : IBanker
{
    public string Numero { get; set; }
    public double Solde { get; protected set; }
    public Personne Titulaire { get; set; }

    public Compte(string numero, Personne titulaire)
    {
        Numero = numero;
        Titulaire = titulaire;
    }

    public Compte(string numero, Personne titulaire, double solde)
    {
        Numero = numero;
        Titulaire = titulaire;
        Solde = solde;
    }

    public abstract void Retrait(double montant);

    protected abstract double CalculInteret();

    public void Depot(double montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("Le montant doit être supérieur à 0");
            return;
        }

        Solde += montant;
    }

    public void AppliquerInteret()
    {
        Solde += CalculInteret();
    }
}