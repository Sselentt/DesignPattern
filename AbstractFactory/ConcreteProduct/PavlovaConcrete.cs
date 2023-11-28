using AbstractFactory.Abstract;

namespace AbstractFactory.ConcreteProduct
{
    public class PavlovaConcrete:IPaket,ITartı
    {
        public void Agırlıgı()
        {
            Console.WriteLine("Pavlova Ürünü ağırlığı hesaplanıyor...");
        }

        public void Paketleme()
        {
            Console.WriteLine("Pavlova Ürünü paketleniyor...");
        }
    }
}
