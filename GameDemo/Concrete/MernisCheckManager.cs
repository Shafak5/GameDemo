﻿using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class MernisCheckManager : IMernisCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            return true;
        }
    }
}
