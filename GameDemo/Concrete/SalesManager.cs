using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class SalesManager : ISalesService
    {
        public void SellTo(Player player, Game game)
        {
            Console.WriteLine(player.FirstName + " buyed " + game.Name);
        }

        public void SellTo(Player player, Game game, Campaign campaign)
        {
            Console.WriteLine(player.FirstName + " buyed " + game.Name + " with campaign " + campaign.Name);
        }
    }
}
