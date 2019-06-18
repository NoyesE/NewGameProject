using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameProject3.Models
{
    public class PlayerActions
    {
        private Player gatherWood(Player p)
        {
            p.wood += 1 * p.gatherStrength;

            return p;
        }
    }
}
