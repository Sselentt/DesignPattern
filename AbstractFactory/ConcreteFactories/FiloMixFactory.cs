using AbstractFactory.Abstract;
using AbstractFactory.ConcreteProduct;

namespace AbstractFactory.ConcreteFactories
{
    public class FiloMixFactory : IAbstractCategoryFactory
    {
        public IPaket CreatePaket()
        {
            return new FiloMixConcrete();
        }

        public ITartı CreateTartı()
        {
            return new FiloMixConcrete();
        }
    }
}
