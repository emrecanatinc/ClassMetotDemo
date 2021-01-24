using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientDemo client1 = new ClientDemo();
            client1.Name = "Emre";
            client1.Surname = "Atınç";
            client1.Id = 1111;

            ClientDemo client2 = new ClientDemo();
            client2.Name = "Sonay";
            client2.Surname = "Ergunlu";
            client2.Id = 2222;

            ClientDemo[] clientsdemo = new ClientDemo[] { client1, client2 };

            MusteriManager musteriManager = new MusteriManager();

            foreach (var client in clientsdemo)

            {
                musteriManager.Ekle(client);
            }


            foreach (var client in clientsdemo)

            {
                musteriManager.Ekle(client);
            }
            
        }
    }
}
