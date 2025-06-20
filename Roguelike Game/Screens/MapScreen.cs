﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roguelike_Game
{
    public partial class MapScreen : UserControl
    {
        // Store the position of the current node relative to the other nodes
        public static int currentRow = 0;
        public static int currentColumn = 3;

        public MapScreen()
        {
            InitializeComponent();

            // Draw the screen once
            Refresh();
        }

        private void MapScreen_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.White);
            SolidBrush sb = new SolidBrush(Color.White);

            // Find which node the player is currently on
            MapNode curNode = Array.Find(Form1.map.nodes, n => n.row == currentRow && n.column == currentColumn);

            foreach (var n in Form1.map.nodes)
            {
                // Draw an full circle for each cleared node, and an empty one for uncleared nodes
                if (n.cleared == false)
                {
                    e.Graphics.DrawEllipse(p, n.x, n.y, n.width, n.height);
                }
                else
                {
                    e.Graphics.FillEllipse(sb, n.x, n.y, n.width, n.height);
                }

                // Draw a connecting line between the current node and the available next nodes to show the player where they are able to go next
                if (curNode.row == n.row - 1 && (curNode.column >= n.column - 1 && curNode.column <= n.column + 1 || n.nodeType == "boss"))
                {
                    e.Graphics.DrawLine(p, curNode.x + curNode.width / 2, curNode.y +  curNode.height / 2, n.x + n.width / 2, n.y + n.height / 2);
                }

                // Tell the player their current stats
                hpLabel.Text = $"HP: {Form1.player.hp} / {Form1.player.maxHp}";
                levelLabel.Text = $"LVL: {Form1.player.level}";
                xpLabel.Text = $"XP: {Form1.player.xp} / {Form1.player.xpToNextLevel[Form1.player.level]}";
            }
        }

        private void MapScreen_Click(object sender, EventArgs e)
        {
            // Get mouse position relative to the map screen
            Point mousePos = this.PointToClient(Cursor.Position);

            // Store mouse x and y values
            int mouseX = mousePos.X;
            int mouseY = mousePos.Y;

            // Find if the mouse was in the range of any nodes
            MapNode node = Array.Find(Form1.map.nodes, n => mouseX >= n.x && mouseY >= n.y && mouseX <= n.x + n.width && mouseY <= n.y + n.height);

            // If a node was clicked, run the OnClick method
            if (node != null)
            {
                node.OnClick(this);
            }
        }

        private void MapScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Application.Exit();
                    break;
            }
        }
    }
}
