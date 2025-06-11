using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_Game
{
    public class PlayerHeal : Attack
    {
        public int healing;

        public PlayerHeal()
        {
            pp = ppMax = 3;

            // Default to 1
            healing = 1;

            damage = 1;
            name = "Heal";
        }

        // Increase healing amount by player level
        public void UpdateHealing()
        {
            healing = Form1.player.level + 1;
        }
    }
}
