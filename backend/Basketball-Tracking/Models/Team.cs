using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballTracking.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public virtual List<Player> Players { get; set; }

        public virtual int ConferenceId { get; set; }
    }
}
