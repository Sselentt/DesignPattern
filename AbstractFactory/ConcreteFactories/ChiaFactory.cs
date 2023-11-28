using AbstractFactory.Abstract;
using AbstractFactory.ConcreteProduct;

namespace AbstractFactory.ConcreteFactories
{
    public class ChiaFactory : IAbstractCategoryFactory
    {
        public IPaket CreatePaket()
        {
            return new ChiaConcrete();
        }

        public ITartı CreateTartı()
        {
            return new ChiaConcrete();
        }
    }
}
