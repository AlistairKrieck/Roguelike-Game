﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_Game
{
    public class SmallBeastEnemy : Enemy
    {
        public SmallBeastEnemy()
        {
            // Range of health the enemy can start with
            minHealthRange = 4;
            maxHealthRange = 6;

            // Range of xp the player will recieve for defeating the enemy
            minXpRange = 2;
            maxXpRange = 3;

            GenerateEnemy();

            sprite = Properties.Resources.stolenWolfEnemy;

            // Temp
            attacks = new Attack[2];
            attacks[0] = new Claw();
            attacks[1] = new Gnaw();
        }
    }
}
