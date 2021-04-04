using PlatformSalingGames.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlatformSalingGames.Concrete
{
    public class CampaingCheckManager : ICampaingCheck
    {
        public bool CheckCampaingForGamer(Gamer gamer)
        {
           if(gamer.Birthyear>=1997)
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
