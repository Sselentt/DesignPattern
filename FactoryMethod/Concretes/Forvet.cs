using FactoryMethod.Abstract;

namespace FactoryMethod.Concretes
{
    public class Forvet:IFutbolcu
    {
        public void CalimAt()
        {
            Console.WriteLine("Forvet oyuncusu çalım atıyor..");
        }

        public void Kos()
        {
            Console.WriteLine("Forvet oyuncusu koşuyor..");
        }

        public void Kurtar()
        {
            Console.WriteLine("Forvet oyuncusu top kurtarıyor..");
        }

        public void PressYap()
        {
            Console.WriteLine("Forvet oyuncusu press yapıyor..");
        }

        public void SutCek()
        {
            Console.WriteLine("Forvet oyuncusu şut çekiyor..");
        }

    }
}
