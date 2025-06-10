using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_Game
{
    public class Player
    {
        private int startingHp = 10;
        private int maxLevel = 5;
        private int levelUpHpReward = 2;

        public int maxHp, hp, xp, level;

        public int[] xpToNextLevel = { 1, 5, 10, 15, 25 };

        public Attack[] attacks = new Attack[4];

        public Image sprite;

        public Player()
        {
            // Init all variables on new object creation
            maxHp = hp = startingHp;
            xp = 0;
            level = 0;
            attacks[0] = new Slash();
            attacks[1] = new Heal();
            attacks[2] = null;
            attacks[3] = null;
            sprite = Properties.Resources.stolenPlayer;
        }

        public void CheckLevelUp()
        {
            if (xp >= xpToNextLevel[level] && level < maxLevel)
            {
                // Increase level and reset experience
                level++;
                xp = 0;

                // Fully heal and increase max health
                maxHp += levelUpHpReward;
                hp = maxHp;

                foreach (Attack a in attacks)
                {
                    if (a is Heal)
                    {
                        Heal h = (Heal)a;
                        h.UpdateHealing();
                    }
                }

                if (level == 2)
                {
                    attacks[2] = new BigBash();
                }
            }
        }
    }
}
