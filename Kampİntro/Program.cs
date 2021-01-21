 using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip gğvenliği
            // alias - değer tutucu
            // do not repeat yourself - kendini tekrar etme
           string KategoriEtiketi = "Kategoriler";
           int ogrenciSayisi = 32000;
           double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış buronu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            if(sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            

            Console.WriteLine(KategoriEtiketi);
            
            

        }
      
    }
}
