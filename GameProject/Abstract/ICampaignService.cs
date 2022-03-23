using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        void AddCampaing(Campaign campaign);
        void DeleteCamping(Campaign campaign);
        void UpDateCampaing(Campaign campaign);
    }
}
