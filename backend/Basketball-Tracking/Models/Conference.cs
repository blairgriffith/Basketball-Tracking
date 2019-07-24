using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballTracking.Models
{
    public class Conference
    {
        public int ConferenceId { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }

        public virtual List<Team> Teams { get; set; }
        public virtual int PlayerId { get; set; }
    }
}
