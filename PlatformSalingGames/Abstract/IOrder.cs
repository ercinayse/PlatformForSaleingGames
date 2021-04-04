using PlatformSalingGames.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlatformSalingGames.Abstract
{
    public interface IOrder
    {
        void Order(Gamer gamer, Game game, Campaing campaing);
    }
}
