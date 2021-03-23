using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class ClientManager
    {
        public void ClientAdd(Client client)
        {
            Console.WriteLine($"Yeni Müşteri Tc No : {client.ClientId}\n" +
                $"Adı ve Soyadı : {client.ClientNameSurname}\n" + $"Yaşı : {client.Age}\n" +
                $"Doğum Tarihi : {client.BirthDate}\n");
        }

        public void ClientRemove(Client client) 
        {
            Console.WriteLine($"<<---{client.ClientId} Tc No'lu  <<---\n" 
                + $"<<---{client.ClientNameSurname} İsimli Müşteri <<---\n" 
                + "**** Kayıtlardan Silinmiştir ! ****");
        }
    }
}
