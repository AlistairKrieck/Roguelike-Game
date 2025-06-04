using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_Game
{
    public class Attack
    {
        int damage;
        string name;

        public Attack(int _damage, string _name)
        {
            damage = _damage;
            name = _name;
        }
    }
}
