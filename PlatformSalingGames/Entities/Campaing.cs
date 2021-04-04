using PlatformSalingGames.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlatformSalingGames.Entities
{
    public class Campaing:IEntity
    {
        public string Name { get; set; }
        public double DiscountPercent { get; set; }

    }
}
