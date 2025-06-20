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
    public partial class WinScreen : UserControl
    {
        // For some reason, it didn't rename from WinScreen when I changed it to GameOverScreen and idk how to change it
        public WinScreen()
        {
            InitializeComponent();

            Refresh();
        }

        // Init the positions of all screen elements, and output whether the player has won or lost
        private void WinScreen_Load(object sender, EventArgs e)
        {
            menuButton.Location = new Point((this.Width - menuButton.Width) / 2, this.Height - 125 - menuButton.Height);
            exitButton.Location = new Point((this.Width - exitButton.Width) / 2, this.Height - 25 - exitButton.Height);

            outputLabel.Location = new Point((this.Width - outputLabel.Width) / 2, (this.Height * 1 / 5) - (outputLabel.Height / 2));

            if (Form1.player.hp > 0)
            {
                outputLabel.Text = "You Win!";
            }
            else
            {
                outputLabel.Text = "You Lose!";
            }
        }

        private void WinScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.White), (this.Width - 1100) / 2, 50, 1100, 500);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WinScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
