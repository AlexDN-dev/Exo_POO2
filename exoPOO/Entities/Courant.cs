using exoPOO.Exceptions;

namespace exoPOO.Entities;

public class Courant : Compte
{
        private double _creditLine;

        public Courant(string numero, Personne titulaire) : base(numero, titulaire)
        {
        }

        public Courant(string numero, Personne titulaire, double creditLine) : base(numero, titulaire)
        {
                if (creditLine <= 0)
                {
                        throw new InvalidOperationException();
                }
                _creditLine = creditLine;
        }

        public double CreditLine
        {
                get => _creditLine;
                private set { CreditLine = value >= 0 ? value : CreditLine; }
        }
        
        

        public override void Retrait(double montant)
        {
                if (montant <= 0)
                {
                        throw new SoldeInsuffisantException("Le montant du retrait doit être positif.");
                }

                Console.WriteLine($"{Solde - montant} - {0- CreditLine}");
                if (Solde - montant < 0 - CreditLine)
                {
                        throw new SoldeInsuffisantException("Il n'y a pas assez d'argent pour retirer ce montant");
                }

                Solde -= montant;

        }

        protected override double CalculInteret()
        {
                if (Solde > 0)
                {
                        return (Solde / 100) * 3;
                }

                return (Solde / 100) * 9.75;
        }
}