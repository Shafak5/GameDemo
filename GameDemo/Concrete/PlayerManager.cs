using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class PlayerManager : IPlayerService
    {
        IMernisCheckService mernisCheckService;

        public PlayerManager(IMernisCheckService mernisCheckService)
        {
            this.mernisCheckService = mernisCheckService;
        }

        public void Add(Player player)
        {
            if (mernisCheckService.CheckIfRealPerson(player)) {
                Console.WriteLine("player added : " + player.FirstName + " " + player.LastName);
            }
            else
            {
                Console.WriteLine("can't add");
            }

        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " deleted");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + " updated");
        }
    }
}
