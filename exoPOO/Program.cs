using exoPOO.Entities;

Banque banque = new Banque("ING");
Compte c1 = new Courant("0124d5ss6a9", new Personne());
c1.Depot(200);

banque.AjouterCompte(c1);
banque.ShowAccountList();
c1.AppliquerInteret();
banque.ShowAccountList();