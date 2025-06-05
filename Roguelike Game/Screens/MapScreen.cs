using System;
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
        Map map = new Map();

        public MapScreen()
        {
            InitializeComponent();

            map.CreateMap(this);
        }

        private void MapScreen_Paint(object sender, PaintEventArgs e)
        {
            Pen b = new Pen(Color.White);
            foreach (var n in map.nodes)
            {
                e.Graphics.DrawEllipse(b, n.x, n.y, n.diameter, n.diameter);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void MapScreen_Click(object sender, EventArgs e)
        {
            // Get mouse position relative to the map screen
            Point mousePos = this.PointToClient(Cursor.Position);

            // Store mouse x and y values
            int mouseX = mousePos.X;
            int mouseY = mousePos.Y;

            // Find if the mouse was in the range of any nodes
            MapNode node = Array.Find(map.nodes, n => mouseX >= n.x && mouseY >= n.y && mouseX <= n.x + n.diameter && mouseY <= n.y + n.diameter);

            // If a node was clicked, run the OnClick method
            if (node != null)
            {
                node.OnClick(this);
            }
        }
    }
}
