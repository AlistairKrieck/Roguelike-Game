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
        int maxHealth, health;
        int xpReward;
        Attack[] attacks;
        //Item[] loot;
        Image sprite;

        public Enemy(int _maxHp, int _xp)
        {
            maxHealth = health = _maxHp;
            xpReward = _xp;

            // Temp
            Attack[] attacks = new Attack[1];
            attacks[0] = new Attack(1, "bash");
        }
    }
}
