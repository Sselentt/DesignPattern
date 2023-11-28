using AbstractFactory.Abstract;
using AbstractFactory.ConcreteProduct;

namespace AbstractFactory.ConcreteFactories
{
    public class GeitostFactory : IAbstractCategoryFactory
    {
        public IPaket CreatePaket()
        {
            return new GeitostConcrete();
        }

        public ITartı CreateTartı()
        {
            return new GeitostConcrete();
        }
    }
}
