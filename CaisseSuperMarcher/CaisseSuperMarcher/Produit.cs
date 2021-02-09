using System;

namespace CaisseSuperMarcher
{


    class Produit
    {
        public String NomProduit;
        
        
        public int IdProduit;


        public Boolean Existreduction;
        public double totReduction;
        public int qte;
        public double PrixProduit;
        
        public Produit(int id, String name , double prix)
        {
            this.IdProduit = id;
            this.NomProduit = name;

            if (!Existreduction)
                this.PrixProduit= prix;
            else
            {
                Existreduction = false;
                
                this.PrixProduit =(this.totReduction + 1) * prix;

            }
            this.qte = 1;
        }


    }
}
