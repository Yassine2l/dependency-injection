﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CaisseSuperMarcher
{
    class ChargementParametre2 : IChargementParametres
    {
        private SystemCentral System;
        public ParamClient involve(int id)
        {
            connect(); //se connecter au systéme centrale
            ParamClient p = System.getClient(id);
            return p;
        }
        public void connect()
        {
            System = new SystemCentral();
        }


    }
}
