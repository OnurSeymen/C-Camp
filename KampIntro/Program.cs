using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*type safety - tip güvenliği C# ve Java bu konuda katıdır.
            String bir şey tanımlamak istiyorsan onun önüne veri türünü yazmalısın.*/
            //Do not repeat yourself!!

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
           

            Console.WriteLine(kategoriEtiketi);

            int day = 2;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                default:
                    break;
            }

            Console.Write("Faktöriyeli bulunacak sayıyı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = 1;

            while (sayi>1)
            {
                sonuc *= sayi;
                sayi--;
            }
            Console.WriteLine("Sonuc : " + sonuc);
            Console.ReadKey();

            int x = 20, y = 10;
            var sonucc = x > y ? "X Büyüktür Y'den" : "X Küçüktür Y'den";//ternary operatörü
            Console.WriteLine(sonucc);

            int z = 15, c = 12;
            var sonuccc = z < c ? "Z Küçüktür C'den" : "Z Büyüktür C'den";
            Console.WriteLine(sonuccc);
        }
    }
}
