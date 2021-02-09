using System;
using System.Collections.Generic;
using System.Text;

namespace CaisseSuperMarcher
{
    class TicketDeCaisse
    {
        private List<Produit> Achat;
        private List<Produit> ListeDesProduits;
        private ChargementParametre chargement;
       
       
        public TicketDeCaisse(List<Produit> P, ChargementParametre chargement)
        {
            this.chargement = chargement;
            Achat = new List<Produit>();
            ListeDesProduits = P;
        }

        public void CumuleAchat()
        {
            foreach(Produit p in ListeDesProduits)
            {
                Achat.Add(p); //Ajouter le produit dans le cumule d'achat
            
            }
        }
        public ParamClient getParamClient(int idClient)
        {
           
            return chargement.involve(idClient);

        }
        public void EditTicket(int idClient)
        {
            
            ParamClient param= this.getParamClient(idClient); 
            String profile = param.ProfilClient;
            double PrixTotal=0;
            StringBuilder printer = new StringBuilder();
            printer.Append("-----------------Ticket-----------------\n");
            foreach (Produit p in Achat)
            {
                PrixTotal += (double) p.PrixProduit * p.qte;
                printer.AppendFormat("Produit : [id :{0}]{1} Quantité : {2} Prix : {3} \n", p.IdProduit,p.NomProduit,p.qte,(double)p.PrixProduit*p.qte);


            }
            printer.AppendFormat("Client Profile : '{0}' \n",profile);
            if (profile == "Famille nombreuse")
            {
                printer.Append("-------------------------------\n");
                printer.AppendFormat("Before 10% of reduction : {0}  \n", PrixTotal);
                printer.Append("-------------------------------\n");
                PrixTotal = (double) PrixTotal *0.9; //10% de reduction si le profile est nombreuse famille
                
            }
            else if(profile == "Selection des produit a prix reduit")
            {
               
                printer.AppendFormat("Before 15% of reduction : {0} \n", PrixTotal);
                
                PrixTotal = (double)PrixTotal * 0.85; // 15% de reduction (profile de reduction)
            }
            //sinon ya aucune reduction sur le prix
          
            printer.AppendFormat("-----------------------------------Total : {0}  \n", PrixTotal);
           
            Console.Write(printer); 
        }

    }
}
