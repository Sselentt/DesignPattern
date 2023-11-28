using FactoryMethod.Abstract;

namespace FactoryMethod.Concretes
{
    public class OrtaSaha:IFutbolcu
    {
        public void CalimAt()
        {
            Console.WriteLine("OrtaSaha oyuncusu çalım atıyor..");
        }

        public void Kos()
        {
            Console.WriteLine("OrtaSaha oyuncusu koşuyor..");
        }

        public void Kurtar()
        {
            Console.WriteLine("OrtaSaha oyuncusu top kurtarıyor..");
        }

        public void PressYap()
        {
            Console.WriteLine("OrtaSaha oyuncusu press yapıyor..");
        }

        public void SutCek()
        {
            Console.WriteLine("OrtaSaha oyuncusu şut çekiyor..");
        }
    }
}
