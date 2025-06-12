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
            int floor = Form1.map.floor;

            // Increase power points by the floor
            pp = ppMax = 3 * floor;

            // Increase healing amount by the floor
            healing = floor;

            // Increase damage by the floor
            damage = floor;

            name = "Heal";
        }
    }
}
