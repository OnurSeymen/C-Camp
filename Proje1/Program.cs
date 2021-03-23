using System;

namespace Proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product menu1 = new Product();
            menu1.ProductTitle = "Elektronik";
            menu1.ProductSubCategory = "Oyuncu Özel";
            menu1.ProductName = "GamePower Kizaru 7.1 Siyah Surround RGB Oyuncu Kulaklık";
            menu1.ProductPrice = "999,00 TL";// ProductPrice ve DiscountedPrice virgüllü gösterim olması için string yazılmıştır.
            menu1.DiscountedPrice = "389,00 TL";

            Product menu2 = new Product();
            menu2.ProductTitle = "Moda-Aksesuar";
            menu2.ProductSubCategory = "Erkek";
            menu2.ProductName = "U.S. Polo Assn. Erkek Beyaz Gömlek Uzunkol 50231405-VR013";
            menu2.ProductPrice = "199,95 TL";
            menu2.DiscountedPrice = "79,99 TL";

            Product[] products = new Product[] { menu1, menu2, };

            for (int i = 0; i < products.Length; i++)//for yazmak bu tarz döngülerde beter bir şey,genel amaç dışında kullanma!
            {
                Console.WriteLine(products[i].ProductTitle + "\n" + products[i].ProductSubCategory + "\n" + products[i].ProductName + "\n" +
                    products[i].ProductPrice + "\n" + products[i].DiscountedPrice);              
            }

            foreach (var product in products) //En kullanışlı döngü türü.
            {
                Console.WriteLine(product.ProductTitle + product.ProductSubCategory + 
                    product.ProductName + product.ProductPrice + product.DiscountedPrice);
            }

            int a = 0;
            while (a < products.Length) 
            {
                Console.WriteLine(products[a].ProductTitle + products[a].ProductSubCategory
                    + products[a].ProductName + products[a].ProductPrice + products[a].DiscountedPrice);
                a++;
            };

        }

        class Product
        {
            public string ProductName { get; set; }
            public string ProductTitle { get; set; }
            public string ProductSubCategory { get; set; }
            public string ProductPrice  { get; set; }
            public string DiscountedPrice { get; set; }
        }
    }
}
