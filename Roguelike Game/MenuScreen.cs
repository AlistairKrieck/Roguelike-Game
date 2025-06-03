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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {
            // Initialize positions of all labels and buttons
            startButton.Location = new Point((this.Width - startButton.Width) / 2, this.Height - 125 - startButton.Height);
            exitButton.Location = new Point((this.Width - exitButton.Width) / 2, this.Height - 25 - exitButton.Height);
            titleLabel.Location = new Point((this.Width - titleLabel.Width) / 2, 25 + titleLabel.Height);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Go to the map screen
            Form1.ChangeScreen(this, new MapScreen());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
