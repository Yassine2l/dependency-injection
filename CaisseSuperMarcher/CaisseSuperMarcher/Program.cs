using System;
using System.Collections.Generic;

namespace CaisseSuperMarcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Magasin m = new Magasin();
            List < Produit > Produits = m.Produits;
            List<Produit> Panier = new List<Produit>();
            Produit Lait = Produits[Produits.FindIndex(item => item.NomProduit == "Lait")];
            Panier.Add(Lait);
            Produit Chocolat = Produits[Produits.FindIndex(item => item.NomProduit == "Chocolat")];
            Panier.Add(Chocolat);

            TicketDeCaisse caisse = new TicketDeCaisse(Panier);
            caisse.CumuleAchat();
            int clientId=1; //client avec l'id qui égale a 1
            caisse.EditTicket(clientId); //editer ticket pour le client avec l'id  1

            Console.ReadLine();
        }
    }
}
