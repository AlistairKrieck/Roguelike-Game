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
        public int x, y;

        //TEMP until boss node is able to be implemented
        public int diameter;
        string nodeType;

        // Whether the map has been chosen or no longer has a path to get to it
        public bool passed;

        public MapNode(int _x, int _y, int _diameter, string _nodeType)
        {
            x = _x;
            y = _y;
            diameter = _diameter;
            nodeType = _nodeType;

            passed = false;
        }

        // Go to relevant screen when clicked
        public void OnClick(UserControl UC)
        {
            if (passed == false)
            {
                switch (nodeType)
                {
                    case "combat":
                        // Create a new enemy and send it to the combat screen
                        CombatScreen.enemy = new Enemy("temp");

                        // Go to the combat screen
                        Form1.ChangeScreen(UC, new CombatScreen());
                        break;

                    case "loot":
                        Form1.ChangeScreen(UC, new LootScreen());
                        break;
                }

                passed = true;
            }
        }
    }
}
