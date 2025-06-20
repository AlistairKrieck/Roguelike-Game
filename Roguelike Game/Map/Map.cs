﻿using System;
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

        // Size of boss node
        int height = 180;
        int width = 180;

        // Number of nodes in each row, with row 0 being the start node and row 4 the boss node
        int row1Count = 2;
        int row2Count = 3;
        int row3Count = 2;

        // Stores each map node in an array
        public MapNode[] nodes;

        // Unused
        public int floor;

        public Map()
        {

        }

        public void CreateMap(UserControl UC)
        {
            // Init nodes array with a size of the sum of all nodes
            nodes = new MapNode[1 + row1Count + row2Count + row3Count + 1];

            // Start node
            nodes[0] = new MapNode(0, 3, UC.Width * 4 / 8 - nodeSize / 2, UC.Height * 7 / 8 - nodeSize / 2, "start");
            nodes[0].passed = nodes[0].cleared = true;

            // First row
            nodes[1] = new MapNode(1, 2, UC.Width * 2 / 8 - nodeSize / 2, UC.Height * 6 / 8 - nodeSize / 2, GetRandNodeType());
            nodes[2] = new MapNode(1, 4, UC.Width * 6 / 8 - nodeSize / 2, UC.Height * 6 / 8 - nodeSize / 2, GetRandNodeType());

            // Second row
            nodes[3] = new MapNode(2, 1, UC.Width * 1 / 8 - nodeSize / 2, UC.Height * 5 / 8 - nodeSize / 2, GetRandNodeType());
            nodes[4] = new MapNode(2, 3, UC.Width * 4 / 8 - nodeSize / 2, UC.Height * 5 / 8 - nodeSize / 2, GetRandNodeType());
            nodes[5] = new MapNode(2, 5, UC.Width * 7 / 8 - nodeSize / 2, UC.Height * 5 / 8 - nodeSize / 2, GetRandNodeType());

            // Third row
            nodes[6] = new MapNode(3, 2, UC.Width * 2 / 8 - nodeSize / 2, UC.Height * 4 / 8 - nodeSize / 2, GetRandNodeType());
            nodes[7] = new MapNode(3, 4, UC.Width * 6 / 8 - nodeSize / 2, UC.Height * 4 / 8 - nodeSize / 2, GetRandNodeType());

            // Boss node
            nodes[8] = new BossNode(4, 3, UC.Width * 4 / 8 - width / 2, UC.Height * 2 / 8 - height / 2);
        }

        // Generate a random node type
        // Redundent in current version
        public string GetRandNodeType()
        {
            // Default to combat room in case of errors
            string type = "combat";

            // Create a random object
            Random random = new Random();

            // Choses randomly between combat and loot rooms
            // TEMP LIMITED TO ONLY COMBAT ROOMS
            switch (random.Next(0, 1))
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
