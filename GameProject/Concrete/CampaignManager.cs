// See https://aka.ms/new-console-template for more information
using GameProject.Abstract;

public class CampaignManager : ICampaignService
{
    public void AddCampaing(Campaign campaign)
    {
        Console.WriteLine(campaign.CampaignName + " kampanya eklendi.");
    }

    public void DeleteCamping(Campaign campaign)
    {
        Console.WriteLine(campaign.CampaignName + " kampanya silindi.");
    }

    public void UpDateCampaing(Campaign campaign)
    {
        Console.WriteLine(campaign.CampaignName + " kampanya güncellendi.");
    }
}