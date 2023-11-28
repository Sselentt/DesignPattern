using AbstractFactory.Abstract;
using AbstractFactory.ConcreteProduct;

namespace AbstractFactory.ConcreteFactories
{
    public class TofuFactory : IAbstractCategoryFactory
    {
        public IPaket CreatePaket()
        {
            return new TofuConcrete();
        }

        public ITartı CreateTartı()
        {
            return new TofuConcrete();
        }
    }
}
