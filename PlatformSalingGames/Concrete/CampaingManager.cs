using PlatformSalingGames.Abstract;
using PlatformSalingGames.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlatformSalingGames.Concrete
{
    public class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("Campaing is added");
        }

        public void Delete(Campaing campaing)
        {
            throw new NotImplementedException();
        }

        public void Update(Campaing campaing)
        {
            throw new NotImplementedException();
        }
    }
}
