using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_Game
{
    public class SmallEnemy : Enemy
    {
        public SmallEnemy()
        {
            // Range of health the enemy can start with
            minHealthRange = 5;
            maxHealthRange = 10;

            // Range of xp the player will recieve for defeating the enemy
            minXpRange = 3;
            maxXpRange = 5;

            GenerateEnemy();

            sprite = Properties.Resources.stolenEnemy;

            // Temp
            attacks = new Attack[1];
            attacks[0] = new Bash();
        }
    }
}
