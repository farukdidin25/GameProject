using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        private IGamerValidateService gamerValidateService;
        public GamerManager(IGamerValidateService gamerValidateService)
        {
            this.gamerValidateService = gamerValidateService;
        }

        public GamerManager()
        {
        }

        public void Register(Gamer gamer)
        {
            if (gamerValidateService.CheckIfRealPerson(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + "  " + gamer.LastName + "  adlı oyuncu başarılı bir şekilde kaydedildi.");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız");
            }
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "  " + gamer.LastName + "  " + " adlı oyuncu silindi.");
        }

        public void UpDate(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "  " + gamer.LastName + "  adlı oyuncu güncellendi.");
        }
    }
}
