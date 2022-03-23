using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface IGamerService
    {
        void Register(Gamer gamer);
        void Delete(Gamer gamer);
        void UpDate(Gamer gamer);
    }
}
