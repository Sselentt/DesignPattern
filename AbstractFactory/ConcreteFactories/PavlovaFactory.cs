using AbstractFactory.Abstract;
using AbstractFactory.ConcreteProduct;

namespace AbstractFactory.ConcreteFactories
{
    public class PavlovaFactory : IAbstractCategoryFactory
    {
        public IPaket CreatePaket()
        {
            return new PavlovaConcrete();
        }

        public ITartı CreateTartı()
        {
            return new PavlovaConcrete();
        }
    }
}
