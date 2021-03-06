﻿using Ninject;
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

            IKernel kernal = new StandardKernel(new MonModule<int>());// creation d'un Kernel qui a un module parametrer par des integer
            TicketDeCaisse caisse = new TicketDeCaisse(Panier, kernal.Get<IChargementParametres>()); //Injection depandance constructeur en utilisent un couplage faible

            caisse.CumuleAchat();
            int clientId=1; //client avec l'id qui égale a 1
            caisse.EditTicket(clientId); //editer ticket pour le client avec l'id  1

            Console.ReadLine();
        }
    }
}
