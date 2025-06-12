using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roguelike_Game
{
    public class BossNode : MapNode
    {
        public BossNode(int _row, int _x, int _y) : base(_row, _x, _y, "boss")
        {
            nodeType = "boss";

            // Size of boss node
            height = 60;
            width = 120;

            passed = false;
        }
    }
}
