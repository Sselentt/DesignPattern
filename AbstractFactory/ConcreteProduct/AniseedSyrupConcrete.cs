using AbstractFactory.Abstract;

namespace AbstractFactory.ConcreteProduct
{
    public class AniseedSyrupConcrete : IPaket, ITartı
    {
        public void Agırlıgı()
        {
            Console.WriteLine("Aniseed Syrup Ürünü ağırlığı hesaplanıyor...");
        }

        public void Paketleme()
        {
            Console.WriteLine("Aniseed Syrup Ürünü paketleniyor...");
        }
    }
}
