using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roguelike_Game
{
    public class MapNode
    {
        // Position
        public int x, y, row;

        public int height = 40;
        public int width = 40;

        public string nodeType;

        // Whether the map has been chosen or no longer has a path to get to it
        public bool passed;

        public MapNode(int _row, int _x, int _y, string _nodeType)
        {
            row = _row;
            x = _x;
            y = _y;
            nodeType = _nodeType;

            passed = false;
        }

        // Go to relevant screen when clicked
        public void OnClick(UserControl UC)
        {
            if (passed == false && MapScreen.currentRow == this.row)
            {
                // Move up one row
                MapScreen.currentRow++;

                switch (nodeType)
                {
                    case "combat":
                        // Create a new enemy and send it to the combat screen
                        CombatScreen.enemy = GenEnemyNode();

                        // Go to the combat screen
                        Form1.ChangeScreen(UC, new CombatScreen());
                        break;

                    case "loot":
                        Form1.ChangeScreen(UC, new LootScreen());
                        break;
                }

                PassNodes();
            }
        }


        private void PassNodes()
        {
            foreach (MapNode n in Form1.map.nodes)
            {
                if (n.row <= this.row)
                {
                    n.passed = true;
                }
            }
        }


        private Enemy GenEnemyNode()
        {
            Enemy e = new Enemy();

            if (Form1.map.floor == 1)
            {
                e = new SmallEnemy();
            }
            // else do other types of enemy

            // TEMP
            else
            {
                e = new SmallEnemy();
            }

            return e;
        }
    }
}
