using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_Game
{
    public class Attack
    {
        public int damage;
        public string name;

        // Power points
        // Limits the number of times the player can use an attack per battle
        public int pp, ppMax;
    }
}
