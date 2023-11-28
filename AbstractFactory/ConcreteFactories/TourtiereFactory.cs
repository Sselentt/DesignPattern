using AbstractFactory.Abstract;
using AbstractFactory.ConcreteProduct;

namespace AbstractFactory.ConcreteFactories
{
    public class TourtiereFactory : IAbstractCategoryFactory
    {
        public IPaket CreatePaket()
        {
            return new TourtiereConcrete();
        }

        public ITartı CreateTartı()
        {
            return new TourtiereConcrete();
        }
    }
}
