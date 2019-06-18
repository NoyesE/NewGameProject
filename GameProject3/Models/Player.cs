using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameProject3.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int wood { get; set; }
        public int lumberHut { get; set; }
        public int gatherStrength { get; set; }

        private Player gatherWood(Player p)
        {
            p.wood += 1 * p.gatherStrength;

            return p;
        }
    }
}
