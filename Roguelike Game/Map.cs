using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roguelike_Game
{
    public class Map
    {
        // The diameter of each node
        int nodeSize = 40;

        // Number of nodes in each row, with row 0 being the start
        int row1Count = 2;
        int row2Count = 3;

        // Stores each map node in an array
        public MapNode[] nodes;
        public Map()
        {

        }

        public void CreateMap(UserControl UC)
        {
            // Init nodes array with a size of the sum of all nodes
            nodes = new MapNode[1 + row1Count + row2Count];

            // Stores current position in nodes array
            int n = 0;

            // Create starting node where the player will begin
            nodes[0] = new MapNode(UC.Width * 4 / 8 - nodeSize / 2, UC.Height * 7 / 8 - nodeSize / 2, nodeSize, "start");

            nodes[1] = new MapNode(UC.Width * 2 / 8 - nodeSize / 2, UC.Height * 6 / 8 - nodeSize / 2, nodeSize, GetRandNodeType());
            nodes[2] = new MapNode(UC.Width * 6 / 8 - nodeSize / 2, UC.Height * 6 / 8 - nodeSize / 2, nodeSize, GetRandNodeType());

            nodes[3] = new MapNode(UC.Width * 1 / 8 - nodeSize / 2, UC.Height * 5 / 8 - nodeSize / 2, nodeSize, GetRandNodeType());
            nodes[4] = new MapNode(UC.Width * 4 / 8 - nodeSize / 2, UC.Height * 5 / 8 - nodeSize / 2, nodeSize, GetRandNodeType());
            nodes[5] = new MapNode(UC.Width * 7 / 8 - nodeSize / 2, UC.Height * 5 / 8 - nodeSize / 2, nodeSize, GetRandNodeType());
        }

        public string GetRandNodeType()
        {
            // Default to combat room in case of errors
            string type = "combat";

            // Create a random object
            Random random = new Random();

            // Choses randomly between combat and loot rooms
            switch (random.Next(0, 2))
            {
                case 0:
                    type = "combat";
                    break;
                case 1:
                    type = "loot";
                    break;
            }

            // Returns random type
            return type;
        }
    }
}
