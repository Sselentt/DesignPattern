using AbstractFactory.Abstract;

namespace AbstractFactory.ConcreteProduct
{
    public class ChiaConcrete : IPaket, ITartı
    {
        public void Agırlıgı()
        {
            Console.WriteLine("Chia Ürünü ağırlığı hesaplanıyor...");
        }

        public void Paketleme()
        {
            Console.WriteLine("Chia Ürünü paketleniyor...");
        }
    }
}
