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
    public partial class EndScreen : UserControl
    {
        public EndScreen()
        {
            InitializeComponent();
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {
            mainMenuButton.Location = new Point((this.Width - mainMenuButton.Width) / 2, this.Height - 125 - mainMenuButton.Height);
            exitButton.Location = new Point((this.Width - exitButton.Width) / 2, this.Height - 25 - exitButton.Height);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
