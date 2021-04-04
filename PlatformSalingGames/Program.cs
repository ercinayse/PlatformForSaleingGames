using PlatformForSaleingGames.Adapter;
using PlatformSalingGames.Abstract;
using PlatformSalingGames.Concrete;
using PlatformSalingGames.Entities;
using System;

namespace PlatformSalingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            {
                TCKN = 12345678910,
                Name="Ayşe",
                Surname="Erçin",
                Birthyear = 1997
            };
            Campaing campaing = new Campaing{
                Name = "Ramadan",
                DiscountPercent = 5
            };

            Game game = new Game
            {
                Name = "Cyberpunk",
                Price = 150,
                ReleaseYear = 2021
            };

            GamerManager gamerManager = new GamerManager(new ValidationWithMernis());
            gamerManager.Register(gamer);

            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Add(campaing);
            OrderManager orderManager = new OrderManager(new CampaingCheckManager());
            orderManager.Order(gamer, game, campaing);

            Console.ReadKey();
           
        }
    }
}
