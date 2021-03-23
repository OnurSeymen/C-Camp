using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_Ornegi
{
    class OtoparkUcreti
    {//Şimdilik çok kasmıyorum yapmak için yapıyorum yoksanam ha bu setlerin içine if else koşulları yazılıp burdan okunur bu.
        public int kalinanSure 
        { 
            get
            {
                return kalinanSure;
            } 
            set 
            {
                Console.Write("Kalınan Süreyi Giriniz : ");
                kalinanSure = Convert.ToInt32(Console.ReadLine());
            } 
        }
        public int aracTipi
        {
            get
            {
                return aracTipi;
            }
            set
            {
                Console.WriteLine("Araç Tipleri <--- Taksi : 1 --- Minibüs : 2 --- Ticari : 3 --->");
                Console.Write("Lütfen Araç Tiplerini Giriniz : ");
                aracTipi = Convert.ToInt32(Console.ReadLine());
            }
        }
        public double odenecekTutar { get; set; }

    }
}
