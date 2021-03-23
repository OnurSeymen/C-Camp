using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 çıktısı kaç olur ? Cevap 30 neden ?= değer tiplerde sadece değerler üzerinden stack'te işlem yapılır ve o anki değeri saklar.

            int[] sayilar1 = new int [] { 10, 20, 30 };//eşitleme sonrası sayilar1 arrayi bu referansı artık kullanmayacağı içi garbage collector bu kısmı siler.
            int[] sayilar2 = new int [] { 100,200,300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1 in 0.index i kaç olur ? Cevap 999 neden ?= Çünkü referans tipler heap de bir pointer karşılığı bulunur ve adreste tutulur
            //Bu yüzden sen sayilar1 i sayilar2 adresine eşitlediğinden dolayı referansı değişir ve eleman da dolayısıyla değişir.

        }
    }
}
