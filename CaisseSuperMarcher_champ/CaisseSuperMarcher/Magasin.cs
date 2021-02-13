using System;
using System.Collections.Generic;
using System.Text;

namespace CaisseSuperMarcher
{
    class Magasin
    {
        public List<Produit> Produits = new List<Produit>();

        public Magasin()
        {
            SetProduit();
        }

        public void SetProduit()
        {
            Produit p1 = new Produit(1, "Chocolat", 3.2);
            p1.SetReduction(0.2); // 20% de reduction
            Produit p2 = new Produit(2, "Lait", 4.0);

            Produit p3 = new Produit(3, "biscuit", 1);
            Produits.Add(p1);
            Produits.Add(p2);
            Produits.Add(p3);
        }
    }
}
