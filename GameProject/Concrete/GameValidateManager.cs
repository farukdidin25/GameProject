using GameProject.Abstract;
using GameProject.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class GamerValidateManager : IGamerValidateService
    {
        IGamerValidateService gamerValidateService;
        public bool CheckIfRealPerson(Gamer gamer)
        {
            gamerValidateService = new MernisServiceAdapter();
            return gamerValidateService.CheckIfRealPerson(gamer);
        }
    }
}
