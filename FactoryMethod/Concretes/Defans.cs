using FactoryMethod.Abstract;

namespace FactoryMethod.Concretes
{
    public class Defans : IFutbolcu
    {
        public void CalimAt()
        {
            Console.WriteLine("defans oyuncusu çalım atıyor..");
        }

        public void Kos()
        {
            Console.WriteLine("defans oyuncusu koşuyor..");
        }

        public void Kurtar()
        {
            Console.WriteLine("defans oyuncusu top kurtarıyor..");
        }

        public void PressYap()
        {
            Console.WriteLine("defans oyuncusu press yapıyor..");
        }

        public void SutCek()
        {
            Console.WriteLine("defans oyuncusu şut çekiyor..");
        }
    }
}
