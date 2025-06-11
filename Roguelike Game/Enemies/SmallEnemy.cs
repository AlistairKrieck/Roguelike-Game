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
            maxHealthRange = 7;

            // Range of xp the player will recieve for defeating the enemy
            minXpRange = 1;
            maxXpRange = 2;

            GenerateEnemy();

            sprite = Properties.Resources.stolenEnemy;

            // Temp
            attacks = new Attack[2];
            attacks[0] = new Bash();
            attacks[1] = new EnemyHeal();
        }
    }
}
