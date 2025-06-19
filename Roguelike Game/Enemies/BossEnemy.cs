using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_Game
{
    public class BossEnemy : Enemy
    {
        public BossEnemy()
        {
            // Range of health the enemy can start with
            // Multiply it by the floor to double health on floor two, etc.
            minHealthRange = 25 * Form1.map.floor;
            maxHealthRange = 30 * Form1.map.floor;

            // Range of xp the player will recieve for defeating the enemy
            // Multiply it by the floor to double xp on floor two, etc.
            minXpRange = 15 * Form1.map.floor;
            maxXpRange = 20 * Form1.map.floor;

            GenerateEnemy();

            sprite = Properties.Resources.stolenBoss;

            attacks = new Attack[3];
            attacks[0] = new Bash();
            attacks[1] = new EnemyHeal();
            attacks[2] = new BigBash();
        }
    }
}
