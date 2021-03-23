using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            //Array-Dizi
            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", 
                "Programlamaya başlangıç için temel kurs", 
                "Java","Python"};

            for (int i = 0; i < kurslar.Length; i++)//Daha genel amaçlar için kullanılır.
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)//Dizi temelli yapıları tek tek dönmeye yarar,Dizileri kolay dolaşmak için kullanılır.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
