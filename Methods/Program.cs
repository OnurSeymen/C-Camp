using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbekir Karpuzu";

            Product[] urunler = new Product[] {urun1,urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------------------------");
            }

            Console.WriteLine("------------Metodlar-----------");

            SepetManager sepetManager = new SepetManager();// Instance bu yapılan işlemin adı (örnekleme) > Instance Of
            sepetManager.Ekle(urun1);//Metod bana reusability yani tekrar tekrar kullanma imkanı sağlıyor farklı yerlerde.
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,3);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,4);
            /*Eğer kullanmak istediğin nesneleri gidip bir sınıfın içindeki metoda parametre olarak tanımlar ve sonrasında 
             * tek tek elle girdirmeye çalışırsan,ileride oluşacak bir isteğe karşılık vermen gerektiğinde programın her yerden patlar.
             * Bunun önüne geçmek için ürün özelliklerinin olduğu
             * Sınıfın içine yeni bir özellik ekler ve bu özelliği diğer sınıflardaki yerlerine yayarsan
             * buna Encapsulation deniyor.
             * Karışık gelebilir ama aslında basit.Diğeri gibi yaparsan sürekli program patlıyor.
            */

        }
    }
}
//Metodlar,bizim için tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
//Don't repeat yourself - DRY - Clean Code - Best Practice
//C#,JAVA Gibi dillerde yazılan tüm kodlar classlardan oluşur.Çok küçük istisnai konfigürasyon dosyaları hariç.
//Class isimleri Pascal Case'dediğimiz bir kural nedeniyle ilk harfi büyük yapılıyor.
//Birden fazla eleman tutmak için kullanıyorsun zaten çok şükür biliyorsun bunları.
//Sınıflar 2 tip veri tutar 1.si ürünün özellikleri.
//2.si ise operasyon kısmı bunlar genelde "Manager,Service,Dal,DataAccess,Controller" gibi ifadelerle gösterilir.
