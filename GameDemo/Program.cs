using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    public class Program
    {
        private const int V = 10;

        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.FirstName = "ferhat";
            player1.LastName = "kara";
            player1.Id = 1;
            player1.NationalityId = 12345678901;
            player1.DateOfBirth.ToString ("15/10/1999");

            PlayerManager playerManager = new PlayerManager(new MernisCheckManager());
            playerManager.Add(player1);

            Game game1 = new Game();
            game1.Id = 1;
            game1.Name = "tetris";
            game1.Price = 0;
            game1.Rate = 4;

            SalesManager saleManager = new SalesManager();
            saleManager.SellTo(player1, game1);

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.Name = "new gamer";
            campaign1.Code = "N1";

            saleManager.SellTo(player1, game1, campaign1);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Delete(campaign1);


        }
    }
}
