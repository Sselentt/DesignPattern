using AbstractFactory.Abstract;

namespace AbstractFactory.ConcreteProduct
{
    public class TofuConcrete:IPaket,ITartı
    {
        public void Agırlıgı()
        {
            Console.WriteLine("Tofu Ürünü ağırlığı hesaplanıyor...");
        }

        public void Paketleme()
        {
            Console.WriteLine("Tofu Ürünü paketleniyor...");
        }
    }
}
