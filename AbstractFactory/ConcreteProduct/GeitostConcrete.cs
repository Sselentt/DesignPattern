using AbstractFactory.Abstract;

namespace AbstractFactory.ConcreteProduct
{
    public class GeitostConcrete:IPaket,ITartı
    {
        public void Agırlıgı()
        {
            Console.WriteLine("Geitost Ürünü ağırlığı hesaplanıyor...");
        }

        public void Paketleme()
        {
            Console.WriteLine("Geitost Ürünü paketleniyor...");
        }
    }
}
