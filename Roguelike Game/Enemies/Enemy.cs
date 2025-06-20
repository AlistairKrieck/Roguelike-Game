using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_Game
{
    public class Enemy
    {
        // Range of health the enemy can start with
        public int minHealthRange;
        public int maxHealthRange;

        // Range of xp the player will recieve for defeating the enemy
        public int minXpRange;
        public int maxXpRange;

        public int maxHp, hp;
        public int xpReward;

        public Attack[] attacks;
        public Image sprite;

        // Set the enemies stats to a random value within their assigned ranges
        public void GenerateEnemy()
        {
            // Create a random object
            Random random = new Random();

            // Generate random values within ranges for hp and xp rewards
            maxHp = hp = random.Next(minHealthRange, maxHealthRange + 1);
            xpReward = random.Next(minXpRange, maxXpRange + 1);
        }

        // Select and output a random attack from the attack array
        public Attack Attack()
        {
            Random random = new Random();

            int atk = random.Next(0, attacks.Length);

            // Re-randomize until the chose attack is not out of power points
            while (attacks[atk].pp <= 0)
            {
                atk = random.Next(0, attacks.Length); ;
            }

            // Reduce used attacks power points by 1
            attacks[atk].pp--;

            return attacks[atk];
        }
    }
}
