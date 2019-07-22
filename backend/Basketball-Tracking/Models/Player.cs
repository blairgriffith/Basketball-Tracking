﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballTracking.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }

        public virtual int TeamId { get; set; }
    }
}
