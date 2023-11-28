using AbstractFactory.Abstract;

namespace AbstractFactory.AssemblyLine
{
    public class ProductAssemblyLine
    {
        private IAbstractCategoryFactory _categoryFactory;
        public ProductAssemblyLine(IAbstractCategoryFactory factory)
        {
            _categoryFactory = factory;
        }

        public void AssemblyProduct()
        {
            IPaket paket = _categoryFactory.CreatePaket();
            ITartı tartı = _categoryFactory.CreateTartı();

            Console.WriteLine("Ürün hazırlama işlemi başlıyor...");
            paket.Paketleme();
            tartı.Agırlıgı();
            Console.WriteLine("Ürün işlemleri tamamlandı...");
        }

    }
}
