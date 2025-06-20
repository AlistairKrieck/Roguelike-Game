﻿using System;
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
        private int levelUpHpReward = 3;
        private int levelUpPpReward = 2;

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

            attacks[0] = new Bash();
            attacks[1] = new Slash();
            attacks[2] = new Placeholder();
            attacks[3] = new Placeholder();

            sprite = Properties.Resources.stolenPlayer;
        }

        public void CheckLevelUp()
        {
            // If player has required xp to level up
            if (xp >= xpToNextLevel[level] && level < maxLevel)
            {
                // Increase level and reset experience, carrying overflow to next level
                xp -= xpToNextLevel[level];
                level++;


                // Fully heal and increase max health
                maxHp += levelUpHpReward;
                hp = maxHp;

                // Increase the stats of each attack as is relevent
                foreach (Attack a in attacks)
                {
                    // If the attack is not bash or a placeholder, increase its power points
                    // There doesn't seem to be a way to do "is not" in an if statement, hense the ugliness
                    if (a is Bash || a is Placeholder)
                    {

                    }
                    else
                    {
                        a.ppMax += levelUpPpReward;
                        a.pp = a.ppMax;
                    }

                    if (a is PlayerHeal)
                    {
                        PlayerHeal h = (PlayerHeal)a;
                        h.UpdateHealing();
                    }
                }
            }

            // Give the player the "Heal" attack when they reach level 1
            if (level == 1 && attacks[2] is Placeholder)
            {
                attacks[2] = new PlayerHeal();
            }

            // Give the player the "Big Bash" attack when they reach level 2
            if (level == 2 && attacks[3] is Placeholder)
            {
                attacks[3] = new BigBash();
            }
        }
    }
}
