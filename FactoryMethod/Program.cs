using FactoryMethod.Abstract;
using FactoryMethod.Creator.Abstract;
using FactoryMethod.Creator.Concretes;

namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseFutbolCreater defansConcrete = new DefansConcrete();
            BaseFutbolCreater forvetConcrete = new ForvetConcrete();
            BaseFutbolCreater kaleciConcrete = new KaleciConcrete();
            BaseFutbolCreater ortasahaConcrete = new OrtaSahaConcrete();

            IFutbolcu defans = defansConcrete.CreateFutbolcu();
            IFutbolcu forvet = forvetConcrete.CreateFutbolcu();
            IFutbolcu kaleci = kaleciConcrete.CreateFutbolcu();
            IFutbolcu ortasaha = ortasahaConcrete.CreateFutbolcu();


            defans.Kos();
            forvet.Kos();
            kaleci.Kos();
            ortasaha.Kos();

            Console.WriteLine("---------------------------");

            defans.CalimAt();
            forvet.CalimAt();
            kaleci.CalimAt();
            ortasaha.CalimAt();

            Console.WriteLine("---------------------------");

            defans.PressYap();
            forvet.PressYap();
            kaleci.PressYap();
            ortasaha.PressYap();

            Console.WriteLine("---------------------------");

            kaleci.Kurtar();

            Console.WriteLine("----------------------------");

            defans.SutCek();
            forvet.SutCek();
            kaleci.SutCek();
            ortasaha.SutCek();
            
            Console.Read();
        }
}
}