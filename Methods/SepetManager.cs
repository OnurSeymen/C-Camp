using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SepetManager
    {//naming convention - metodlara verilen isimlerin tıpkı Classlar gibi ilk harfinin büyük olması olayı.
        /*Aşağıdaki ekle metoduna örnek olarak hangi ürünü ekleyeceğimizi belirtmek için yani
         programın hangi nesneyi,ürünü vs. eklemesini tanımlayacağımız alan
        -Parametre- alanıdır()bu parantezlerin içidir.*/
        public void Ekle(Product urun) 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi + "\n" + "Urun Fiyati : " + urun.Fiyati + "TL");
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi) 
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
