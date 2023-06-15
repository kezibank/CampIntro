using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Product product1 = new Product();
            product1.marka = "Evlen Home";
            product1.urunAdi = "Çift Kişilik Nevresim Takımı";
            product1.urunFiyati = 360.02;

            Product product2 = new Product();
            product2.marka = "Ferca";
            product2.urunAdi = "Çatal Kaşık Takımı";
            product2.urunFiyati = 499.99;

            Product product3 = new Product();
            product3.marka = "Elart";
            product3.urunAdi = "Masa Örtüsü";
            product3.urunFiyati = 131.81;

            Product product4 = new Product();
            product4.marka = "Karaca";
            product4.urunAdi = "Çelik Tencere Seti";
            product4.urunFiyati = 1799;

            Product[] product = new Product[] {product1, product2, product3, product4};

            foreach (Product products in product)
            {
                Console.WriteLine(products.marka + " " + products.urunAdi +" "+ products.urunFiyati);
                
            }
        }
    }
}
class Product
{
    public string urunAdi{ get; set; }
    public string marka { get; set; }
    public double urunFiyati { get; set; }
    public string beden { get; set; }
    public string SepeteEkle { get; set; }
}
