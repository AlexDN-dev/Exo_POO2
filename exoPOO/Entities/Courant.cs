namespace exoPOO.Entities;

public class Courant : Compte
{
        private double _creditLine;

        public double CreditLine
        {
                get => _creditLine;
                private set { CreditLine = value >= 0 ? value : CreditLine; }
        }

        public override void Retrait(double montant)
        {
                if (montant <= 0)
                {
                        Console.WriteLine($"le montant doit etre supérieur à 0 ");
                        return;
                }

                if (Solde - montant > Solde + CreditLine)
                {
                        Console.WriteLine("Pas assez d'argent pour retirer ce montant");
                        return;
                }

                Solde -= montant;

        }
}