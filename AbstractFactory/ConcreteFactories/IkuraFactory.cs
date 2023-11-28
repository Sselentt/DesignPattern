using AbstractFactory.Abstract;
using AbstractFactory.ConcreteProduct;

namespace AbstractFactory.ConcreteFactories
{
    public class IkuraFactory : IAbstractCategoryFactory
    {
        public IPaket CreatePaket()
        {
            return new IkuraConcrete();
        }

        public ITartı CreateTartı()
        {
            return new IkuraConcrete();
        }
    }
}
