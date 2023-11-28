using AbstractFactory.Abstract;

namespace AbstractFactory.ConcreteProduct
{
    public class TourtiereConcrete:IPaket,ITartı
    {
        public void Agırlıgı()
        {
            Console.WriteLine("Tourtiere Ürünü ağırlığı hesaplanıyor...");
        }

        public void Paketleme()
        {
            Console.WriteLine("Tourtiere Ürünü paketleniyor...");
        }
    }
}
