﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_Game
{
    public class Bash : Attack
    {
        public Bash()
        {
            pp = ppMax = 999;
            damage = 1;
            name = "Bash";
        }
    }
}
