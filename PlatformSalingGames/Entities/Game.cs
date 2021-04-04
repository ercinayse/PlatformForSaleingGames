using PlatformSalingGames.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlatformSalingGames.Entities
{
    public class Game:IEntity
    {
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public double Price { get; set; }
    }
}
