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
    public partial class CombatScreen : UserControl
    {
        public CombatScreen()
        {
            InitializeComponent();
        }

        private void CombatScreen_Load(object sender, EventArgs e)
        {
            inventoryButton.Location = new Point((this.Width - inventoryButton.Width) / 2, this.Height - 125 - inventoryButton.Height);
            attackMenuButton.Location = new Point((this.Width - attackMenuButton.Width) / 2, this.Height - 25 - attackMenuButton.Height);

            attackButton1.Location = new Point((this.Width * 2/3) - (attackButton1.Width / 2), this.Height - 125 - attackButton1.Height);
            attackButton2.Location = new Point((this.Width * 1/3) - (attackButton2.Width / 2), this.Height - 125 - attackButton2.Height);
            attackButton3.Location = new Point((this.Width * 2 / 3) - (attackButton3.Width / 2), this.Height - 25 - attackButton3.Height);
            attackButton4.Location = new Point((this.Width * 1 / 3) - (attackButton4.Width / 2), this.Height - 25 - attackButton4.Height);

            backButton.Location = new Point((this.Width * 1/9) - (backButton.Width / 2), this.Height - 75 - backButton.Height);

            attackButton1.Visible = false;
            attackButton2.Visible = false;
            attackButton3.Visible = false;
            attackButton4.Visible = false;

            backButton.Visible = false;
        }

        private void attackMenuButton_Click(object sender, EventArgs e)
        {
            inventoryButton.Visible = false;
            attackMenuButton.Visible = false;

            attackButton1.Visible = true;
            attackButton2.Visible = true;
            attackButton3.Visible = true;
            attackButton4.Visible = true;

            backButton.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            inventoryButton.Visible = true;
            attackMenuButton.Visible = true;

            attackButton1.Visible = false;
            attackButton2.Visible = false;
            attackButton3.Visible = false;
            attackButton4.Visible = false;

            backButton.Visible = false;
        }
    }
}
