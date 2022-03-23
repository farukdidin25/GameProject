using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameManager : IGameSaleService
    {
        public void GameSales(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + campaign.CampaignName + " kampanya ile " + game.GameName + " isimli oyunu " + game.UnitPrice + " TL yerine " + game.DiscountedPrice + " TL'ye satın aldı.");
        }

        internal void GameSales(Gamer gamer, Game game)
        {
            throw new NotImplementedException();
        }
    }
}
