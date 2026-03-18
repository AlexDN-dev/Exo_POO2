namespace exoPOO.Entities;

public class Epargne : Compte
{
    public DateTime DateDernierRetrait { get; set; }
    
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
}