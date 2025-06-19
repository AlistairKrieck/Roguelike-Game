using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_Game
{
    public class Gnaw : Attack
    {
        public Gnaw()
        {
            pp = ppMax = 2;
            damage = 3;
            name = "Gnaw";
        }
    }
}
