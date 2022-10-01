using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Game : IGame
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public int Rate { get; set; }
    }
}
