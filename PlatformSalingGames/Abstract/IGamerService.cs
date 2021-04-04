using PlatformSalingGames.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlatformSalingGames
{
    public interface IGamerService
    {
        void Register(Gamer gamer);

        void Update(Gamer gamer);
        void Delete(int TCKN);

        
    }
}
