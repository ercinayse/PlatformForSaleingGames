using PlatformSalingGames.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlatformSalingGames.Abstract
{
    public interface ICampaingService
    {
        void Add(Campaing campaing);
        void Delete(Campaing campaing);
        void Update(Campaing campaing);
    }
}
