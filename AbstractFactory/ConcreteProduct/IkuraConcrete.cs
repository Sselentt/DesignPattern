using AbstractFactory.Abstract;

namespace AbstractFactory.ConcreteProduct
{
    public class IkuraConcrete:IPaket,ITartı
    {
        public void Agırlıgı()
        {
            Console.WriteLine("Ikura Ürünü ağırlığı hesaplanıyor...");
        }

        public void Paketleme()
        {
            Console.WriteLine("Ikura Ürünü paketleniyor...");
        }
    }
}
