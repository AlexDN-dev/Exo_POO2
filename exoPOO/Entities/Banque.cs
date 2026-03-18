namespace exoPOO.Entities;

public class Banque
{
    public string Nom { get; set; }
    private Dictionary<string, Compte> _listeComptes  = new Dictionary<string, Compte>();
    
    public Banque(string nom)
    {
        Nom = nom;
        
    }

    public void AjouterCompte(Compte c)
    {
        _listeComptes.Add(c.Numero, c);
    }

    public void RetirerCompte(string key)
    {
        if (_listeComptes.Remove(key))
        {
            Console.WriteLine($"Le compte avec le numéro {key} à bien été supprimé.");
        }
        else
        {
            Console.WriteLine("Ce compte n'existe pas !");
        }
    }

    public void ShowAccountList()
    {
        if (_listeComptes.Count == 0)
        {
            Console.WriteLine("Il n'y a pas de compte dans cette banque !");
            return;
        }
        foreach (var c in _listeComptes)
        {
            Console.WriteLine(c.Key + " " + c.Value.Solde);
        }
    }
}