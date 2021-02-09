using System;
using System.Collections.Generic;
using System.Text;

namespace CaisseSuperMarcher
{
    class SystemCentral
    {
        List<ParamClient> Clients = new List<ParamClient>()
        {
            new ParamClient(){ ProfilClient = "Famille nombreuse"},
            new ParamClient(){ ProfilClient = "Selection des produit a prix reduit"},
            new ParamClient(){ ProfilClient = "Produit reduit"},
            new ParamClient(){ ProfilClient = "Selection des produit a prix reduit"},
            new ParamClient(){ ProfilClient = "Selection des produit a prix reduit"}
        };
        

        public ParamClient getClient(int id)
        {
            return Clients[id];
        }


    }
}
