using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_Game
{
    public class Claw : Attack
    {
        public Claw()
        {
            pp = ppMax = 999;
            damage = 2;
            name = "Claw";
        }
    }
}
