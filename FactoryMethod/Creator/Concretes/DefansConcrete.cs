using FactoryMethod.Abstract;
using FactoryMethod.Concretes;
using FactoryMethod.Creator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creator.Concretes
{
    public class DefansConcrete : BaseFutbolCreater
    {
        public override IFutbolcu CreateFutbolcu()
        {
            return new Defans();
        }
    }
}
