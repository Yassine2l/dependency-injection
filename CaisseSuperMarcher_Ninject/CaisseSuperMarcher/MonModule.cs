using Ninject.Modules;
using System;
 
namespace CaisseSuperMarcher
{
    class MonModule<T> : NinjectModule
    {
        public override void Load()
        {
            Type t = typeof(T);
            if(t == typeof(int))
            Bind<IChargementParametres>().To<ChargementParametre2>();// si le type passer en parmetre de la classe est un int alors on bind la 2eme implementation
            else
            Bind<IChargementParametres>().To<ChargementParametre>();// sinon on bind la 1er implementation
        }
    }
}
