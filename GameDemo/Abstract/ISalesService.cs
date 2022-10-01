using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface  ISalesService
    {
        void SellTo(Player player, Game game);
        void SellTo(Player player, Game game, Campaign campaign);
    }
}
