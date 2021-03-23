using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        { // => müşterilerin hepsini buradan tek tek kendim girerek değil,ekrandan readline yaparak alacağım,
          // => her girilen değer okunup Client sınıfındaki metodlara aktarılacak.
          // => Manager'dan ekleme ve silme işlemi detay gönderimi yapılacak.Ana fonksiyonlar mainde olacak.
          

            
            int choose;
            Console.WriteLine("=> Müşteri Kayıt Ekranına Hoşgeldiniz.. <= \n      => Giriş İçin 1'e Basınız <=");
            choose = Convert.ToInt32(Console.ReadLine());

            if (choose != 1) { Console.WriteLine("Lütfen 1'e basar mısın lan hıyar arkadaşım. |--_--|"); }    

            while (choose == 1) 
                {
                    Client client1 = new Client();
                    Console.WriteLine("Yeni Müşteri Tc No Giriniz : ");
                    client1.ClientId = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Müşteri İsmi ve Soyismi : ");
                    client1.ClientNameSurname = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Müşterinin Yaşı : ");
                    client1.Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Doğum Tarihi : ");
                    client1.BirthDate = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("\n====>>>>-----Yeni Müşteri Eklendi-----<<<<<====\n");

                    Console.WriteLine("          ---> Menüden İşlem Seçiniz <---     " + "\n" +
                    "1 => Müşteri ekleme <=\n" + "2 => Müşterileri Listeleme <=\n" + "3 => Müşteri Silme <=\n");
                    choose = Convert.ToInt32(Console.ReadLine());

                if (choose == 2)
                {
                    {
                        ClientManager clientManager = new ClientManager();

                        Client[] clients = new Client[] { client1 };

                        foreach (Client client in clients)
                        {
                            clientManager.ClientAdd(client);
                        }

                    }
                }
                else if (choose == 3)
                {

                    ClientManager clientManager = new ClientManager();

                    Client[] clients = new Client[] { client1 };

                    foreach (Client client in clients)
                        
                    clientManager.ClientRemove(client);
                    

                }
      
            }
                        
        }
    }
}
