using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_Game
{
    public class EnemyHeal : Attack
    {
        public int healing;

        public EnemyHeal()
        {
            // Default to 1
            healing = 1;

            damage = 1;
            name = "Heal";
        }

        // Increase healing amount by the floor
        public void UpdateHealing()
        {
            healing = Form1.map.floor + 1;
        }
    }
}
