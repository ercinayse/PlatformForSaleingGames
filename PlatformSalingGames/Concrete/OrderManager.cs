using PlatformSalingGames.Abstract;
using PlatformSalingGames.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlatformSalingGames.Concrete
{
    public class OrderManager : IOrder
    {
        ICampaingCheck _campaingCheck;
        public OrderManager(ICampaingCheck campaingCheck)
        {
            _campaingCheck = campaingCheck;
        }
        public void Order(Gamer gamer, Game game, Campaing campaing)
        {
            if (_campaingCheck.CheckCampaingForGamer(gamer))
            {
                double totalPrice = game.Price - (game.Price * campaing.DiscountPercent/100);
                Console.WriteLine("Your new price is: {0} $",totalPrice);
            }
            

        }
    }
}
