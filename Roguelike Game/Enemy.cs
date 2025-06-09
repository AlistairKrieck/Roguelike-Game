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
        public int maxHealth, health;
        public int xpReward;

        // Will eventually be replaced with a set of subclasses
        // Will determine hp and xp ranges and what attacks the enemy can have
        public string enemyType;

        public Attack[] attacks;
        //public Item[] loot;
        public Image sprite;

        public Enemy(string _enemyType)
        {
            enemyType = _enemyType;

            GenerateEnemy();
            SetSprite();

            // Temp
            attacks = new Attack[1];
            attacks[0] = new Bash();
        }

        private void GenerateEnemy()
        {
            // Create a random object
            Random random = new Random();

            // Range of health the enemy can start with
            int minEnemyHealth = 5;
            int maxEnemyHealth = 10;

            // Range of xp the player will recieve for defeating the enemy
            int minXpReward = 3;
            int maxXpReward = 5;

            // Generate random values within ranges for hp and xp rewards
            maxHealth = health = random.Next(minEnemyHealth, maxEnemyHealth + 1);
            xpReward = random.Next(minXpReward, maxXpReward + 1);
        }

        private void SetSprite()
        {
            switch (enemyType)
            {
                default:
                    sprite = Properties.Resources.stolenEnemy;
                    break;
            }
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
