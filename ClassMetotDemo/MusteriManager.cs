using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(ClientDemo client)
        {
            Console.WriteLine("Sitemize Hoşgeldiniz " + client.Name + " " + client.Surname);
        }

        public void Listele(ClientDemo client)
        {
            Console.WriteLine("----Müşteri Bilgisi------");
            Console.WriteLine("Name " + client.Name);
            Console.WriteLine("Surname " + client.Surname);
            Console.WriteLine("Id " + client.Id);
            Console.WriteLine("----------------------------");


        }

        public void Silme(ClientDemo client)
        {
            Console.WriteLine("Hesap Silindi " + client.Name + " " + client.Surname);
        }


    }
}
