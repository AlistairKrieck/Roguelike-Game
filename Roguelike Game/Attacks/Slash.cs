﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_Game
{
    public class Slash : Attack
    {
        public Slash()
        {
            pp = ppMax = 3;
            damage = 2;
            name = "Slash";
        }
    }
}
