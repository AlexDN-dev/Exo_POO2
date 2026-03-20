using exoPOO.Entities;

namespace exoPOO.Interfaces;

public interface IBanker : ICustomer
{
    void AppliquerInteret();

    Personne Titulaire { get; }
    string Numero { get; }
}