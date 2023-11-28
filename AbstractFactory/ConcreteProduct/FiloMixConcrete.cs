using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteProduct
{
    public class FiloMixConcrete:IPaket,ITartı
    {
        public void Agırlıgı()
        {
            Console.WriteLine("Filo Mix Ürünü ağırlığı hesaplanıyor...");
        }

        public void Paketleme()
        {
            Console.WriteLine("Filo Mix Ürünü paketleniyor...");
        }
    }
}
