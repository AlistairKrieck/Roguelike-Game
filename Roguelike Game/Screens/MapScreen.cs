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
    }
}
