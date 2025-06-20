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
        public static Random random = new Random();

        // Position
        public int x, y, row, column;

        // Size
        public int height = 40;
        public int width = 40;

        public string nodeType;

        // Whether the node no longer has a path to get to it
        public bool passed;

        // Whether the node has been chosen
        public bool cleared;

        public MapNode(int _row, int _column, int _x, int _y, string _nodeType)
        {
            row = _row;
            column = _column;
            x = _x;
            y = _y;
            nodeType = _nodeType;

            passed = false;
        }

        // Go to relevant screen when clicked
        public void OnClick(UserControl UC)
        {
            // Only allow the player to click a node if they have just cleared the previous row
            // and are on a node left, right, or below the current column, or clicked the boss node
            if (MapScreen.currentRow == this.row - 1 && (MapScreen.currentColumn >= this.column - 1 && MapScreen.currentColumn <= this.column + 1 || this.nodeType == "boss"))
            {
                this.cleared = true;

                // Move up one row
                MapScreen.currentRow++;

                // Move to the column of the clicked node
                MapScreen.currentColumn = this.column;

                switch (nodeType)
                {
                    case "combat":
                    case "boss":
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

        // Prevent the player from accessing nodes that they have passed
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

        // Get a random type of enemy for combat nodes based on the floor
        private Enemy GenEnemyNode()
        {
            Enemy e = new Enemy();

            // Set the enemy to a boss
            if (nodeType == "boss")
            {
                e = new BossEnemy();
            }

            // Chose a random floor one enemy
            else if (Form1.map.floor == 1)
            {
                switch (random.Next(0, 2))
                {
                    case 0:
                        e = new SmallRobotEnemy();
                        break;

                    case 1:
                        e = new SmallBeastEnemy();
                        break;
                }

            }

            // else do other types of enemy for other floors

            // If something goes wrong, default to a floor 1 bot enemy
            else
            {
                e = new SmallRobotEnemy();
            }

            return e;
        }
    }
}
