using PlatformSalingGames.Abstract;
using PlatformSalingGames.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlatformSalingGames.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheck _gamerCheck;
      
        
        public GamerManager(IGamerCheck gamerCheck)
        {
            _gamerCheck = gamerCheck;
            
        }
        

        public void Delete(int TCKN)
        {
            Console.WriteLine("Gamer ise deleted");
        }

        public void Register(Gamer gamer)
        {
            if(_gamerCheck.CheckGamer(gamer))
            {
                Console.WriteLine("Gamer is registered.");
            }
        }

       

        

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer is updated");
        }
    }
}
