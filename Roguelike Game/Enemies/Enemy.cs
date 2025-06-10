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

        public int maxHealth, health;
        public int xpReward;

        public Attack[] attacks;
        //public Item[] loot;
        public Image sprite;

        public void GenerateEnemy()
        {
            // Create a random object
            Random random = new Random();

            // Generate random values within ranges for hp and xp rewards
            maxHealth = health = random.Next(minHealthRange, maxHealthRange + 1);
            xpReward = random.Next(minXpRange, maxXpRange + 1);
        }

        public void OnDeath()
        {
            Form1.player.xp += xpReward;
        }

        public Attack Attack()
        {
            Random random = new Random();

            int atk = random.Next(0, attacks.Length);

            return attacks[atk];
        }
    }
}
