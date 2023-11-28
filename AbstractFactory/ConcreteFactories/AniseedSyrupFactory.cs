using AbstractFactory.Abstract;
using AbstractFactory.ConcreteProduct;

namespace AbstractFactory.ConcreteFactories
{
    public class AniseedSyrupFactory : IAbstractCategoryFactory
    {
        public IPaket CreatePaket()
        {
            return new AniseedSyrupConcrete();
        }

        public ITartı CreateTartı()
        {
           return new AniseedSyrupConcrete();
        }
    }
}
