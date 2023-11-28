using FactoryMethod.Abstract;
using FactoryMethod.Concretes;
using FactoryMethod.Creator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FactoryMethod.Creator.Concretes
{
    public class OrtaSahaConcrete : BaseFutbolCreater
    {
        public override IFutbolcu CreateFutbolcu()
        {
            return new OrtaSaha();
        }
    }
}
