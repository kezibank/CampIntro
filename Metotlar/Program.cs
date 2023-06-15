using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Dont repeat yourself(Kendini tekrar etme)-Clean Code - Best Practice(doğru uygulama)
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama="Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------");
            }
            Console.WriteLine("------Metotlar-------");

            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,5);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,12);
            //Class kullanmadan metot şeklinde de eklenebilir fakat yeni bir alan eklemek istendiğinde metotun kullanıldığı tüm sayfaları değiştirmek gerekmektedir.
            //Stok adedi eklemeye çalıştığımızda hata verdi.Tek tek tüm ürünlerin adetlerini eklememiz gerekmektedir.
        }
    }
}
