using PlatformSalingGames.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlatformSalingGames
{
    public class Gamer:IEntity
    {
        public long TCKN { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }

        public int Birthyear { get; set; }
    }
}
