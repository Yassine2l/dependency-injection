using System;

namespace CaisseSuperMarcher
{

    class Produit
    {
        public String NomProduit;


        public int IdProduit;

        public int qte;
        public double PrixProduit;

        public Produit(int id, String name, double prix)
        {
            this.IdProduit = id;
            this.NomProduit = name;
            this.PrixProduit = prix;

            this.qte = 1;
        }

        public void SetReduction(double totReduction)
        {
            PrixProduit *= 1 - totReduction;
        }


    }
}
