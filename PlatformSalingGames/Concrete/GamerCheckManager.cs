using PlatformSalingGames.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlatformSalingGames.Concrete
{
    public class GamerCheckManager : IGamerCheck
    {
        public bool CheckGamer(Gamer gamer)
        {
            if(gamer.TCKN.Length==11 && gamer.Birthyear>=1900 && gamer.Birthyear<=DateTime.Now.Year)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
