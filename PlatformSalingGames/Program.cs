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
                TCKN = "51364468957",
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

            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Register(gamer);

            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Add(campaing);
            OrderManager orderManager = new OrderManager(new CampaingCheckManager());
            orderManager.Order(gamer, game, campaing);
           
        }
    }
}
