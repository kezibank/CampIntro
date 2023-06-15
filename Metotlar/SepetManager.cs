using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)//Sepete neyin eklendiğini göstermek için buraya bir parametre girilmesi gerekmektedir.
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
            //Bu class sayesinde farklı sayfadaki sepete ekle butonundaki değişiklikler tek bir yerden yapılacaktır.
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }
    }
}
