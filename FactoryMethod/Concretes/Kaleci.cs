using FactoryMethod.Abstract;

namespace FactoryMethod.Concretes
{
    public class Kaleci:IFutbolcu
    {
        public void CalimAt()
        {
            Console.WriteLine("Kaleci çalım atıyor..");
        }

        public void Kos()
        {
            Console.WriteLine("Kaleci koşuyor..");
        }

        public void Kurtar()
        {
            Console.WriteLine("Kaleci top kurtarıyor..");
        }

        public void PressYap()
        {
            Console.WriteLine("Kaleci press yapıyor..");
        }

        public void SutCek()
        {
            Console.WriteLine("Kaleci şut çekiyor..");
        }
    }
}
