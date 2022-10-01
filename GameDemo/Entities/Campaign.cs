using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    public class Campaign : ICampaign
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Code { get; set; }

    }
}
