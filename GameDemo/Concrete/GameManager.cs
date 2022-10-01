using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " added");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + " deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + " updated");
        }
    }
}
