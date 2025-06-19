using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_Game
{
    public class SmallRobotEnemy : Enemy
    {
        public SmallRobotEnemy()
        {
            // Range of health the enemy can start with
            minHealthRange = 6;
            maxHealthRange = 8;

            // Range of xp the player will recieve for defeating the enemy
            minXpRange = 2;
            maxXpRange = 3;

            GenerateEnemy();

            sprite = Properties.Resources.stolenRobotEnemy;

            // Temp
            attacks = new Attack[3];
            attacks[0] = new Bash();
            attacks[1] = new Slash();
            attacks[2] = new EnemyHeal();
        }
    }
}
