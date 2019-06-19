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
        public int lumberHutCost { get; set; }
        public int stone { get; set; }
        public int stoneGatherStrength { get; set; }
        public int stoneHut { get; set; }
        public int stoneHutCost { get; set; }

        private Player gatherWood(Player p)
        {
            p.wood += 1 * p.gatherStrength;

            return p;
        }
    }
}
