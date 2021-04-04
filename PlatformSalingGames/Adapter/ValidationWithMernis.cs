using Mernis;
using PlatformSalingGames;
using PlatformSalingGames.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlatformForSaleingGames.Adapter
{
    public class ValidationWithMernis : IGamerCheck
    {
        public bool CheckGamer(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(gamer.TCKN, gamer.Name.ToUpper(), gamer.Surname.ToUpper(), gamer.Birthyear).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
