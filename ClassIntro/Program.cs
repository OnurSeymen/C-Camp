using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.EgitmenAdi = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 76;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.EgitmenAdi = "Hayri Kolsuz";
            kurs2.IzlenmeOrani = 45;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.EgitmenAdi = "Kalayito Massimo";
            kurs3.IzlenmeOrani = 95;

            // Console.WriteLine(kurs1.KursAdi + " " + kurs1.EgitmenAdi);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " " + kurs.EgitmenAdi + " " + kurs.IzlenmeOrani);
            }
        }

        class Kurs
        {
            public string KursAdi { get; set; }
            public string EgitmenAdi { get; set; }
            public int IzlenmeOrani { get; set; }
        }
        
    }
}
