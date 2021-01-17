using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product produsct1 = new Product();
            produsct1.Adi = "Elma";
            produsct1.Fiyati = 15;
            produsct1.Aciklama = "Amasya";

            Product produsct2 = new Product();
            produsct2.Adi = "Karpuz";
            produsct2.Fiyati = 80;
            produsct2.Aciklama = "Diyarbakır";

            Product[] Urunler = new Product[] {produsct1,produsct2 };

            foreach (Product urun in Urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("---------Metotlar---------");

            //instence - örnek 
            // encupsulation

            sepetManager sepetmanager = new sepetManager();
            sepetmanager.Ekle(produsct1);
            sepetmanager.Ekle(produsct2);

            sepetmanager.Ekle2("Armut","Yeşil",12);
        }
    }
}





// don't repeat yourself 