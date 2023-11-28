using AbstractFactory.Abstract;
using AbstractFactory.AssemblyLine;
using AbstractFactory.ConcreteFactories;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IAbstractCategoryFactory aniseedsyrup = new AniseedSyrupFactory();
            ProductAssemblyLine AniseedSyrupAssemblyLine = new ProductAssemblyLine(aniseedsyrup);
            AniseedSyrupAssemblyLine.AssemblyProduct();

            Console.WriteLine("------------------------------------");

            IAbstractCategoryFactory chiafactory = new ChiaFactory();
            ProductAssemblyLine ChiaFactoryAssemblyLine = new ProductAssemblyLine(chiafactory);
            ChiaFactoryAssemblyLine.AssemblyProduct();

            Console.WriteLine("------------------------------------");

            IAbstractCategoryFactory filomix = new FiloMixFactory();
            ProductAssemblyLine FiloMixAssemblyLine = new ProductAssemblyLine(filomix);
            FiloMixAssemblyLine.AssemblyProduct();

            Console.WriteLine("------------------------------------");

            IAbstractCategoryFactory geitost = new GeitostFactory();
            ProductAssemblyLine GeitostAssemblyLine = new ProductAssemblyLine(geitost);
            GeitostAssemblyLine.AssemblyProduct();

            Console.WriteLine("------------------------------------");

            IAbstractCategoryFactory ıkura = new IkuraFactory();
            ProductAssemblyLine IkuraAssemblyLine = new ProductAssemblyLine(ıkura);
            IkuraAssemblyLine.AssemblyProduct();

            Console.WriteLine("------------------------------------");

            IAbstractCategoryFactory pavlova = new PavlovaFactory();
            ProductAssemblyLine PavlovaAssemblyLine = new ProductAssemblyLine(pavlova);
            PavlovaAssemblyLine.AssemblyProduct();

            Console.WriteLine("------------------------------------");

            IAbstractCategoryFactory tofu = new TofuFactory();
            ProductAssemblyLine TofuAssemblyLine = new ProductAssemblyLine(tofu);
            TofuAssemblyLine.AssemblyProduct();

            Console.WriteLine("------------------------------------");

            IAbstractCategoryFactory tourtiere = new TourtiereFactory();
            ProductAssemblyLine TourtiereAssemblyLine = new ProductAssemblyLine(tourtiere);
            TourtiereAssemblyLine.AssemblyProduct();


            Console.Read();



        }
    }
}