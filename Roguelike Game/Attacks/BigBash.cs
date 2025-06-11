using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_Game
{
    public class BigBash : Attack
    {
        public BigBash()
        {
            pp = ppMax = 5;
            damage = 3;
            name = "Big Bash";
        }
    }
}
