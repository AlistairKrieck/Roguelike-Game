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
        public static Enemy enemy;
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush greenBrush = new SolidBrush(Color.Green);

        public CombatScreen()
        {
            InitializeComponent();

            enemy = new Enemy("temp");
        }

        // Initilaze position of all components
        private void CombatScreen_Load(object sender, EventArgs e)
        {
            // Initialize positions of all labels and buttons
            inventoryButton.Location = new Point((this.Width - inventoryButton.Width) / 2, this.Height - 25 - inventoryButton.Height);
            attackMenuButton.Location = new Point((this.Width - attackMenuButton.Width) / 2, this.Height - 125 - attackMenuButton.Height);
            attackButton1.Location = new Point((this.Width * 2 / 3) - (attackButton1.Width / 2), this.Height - 125 - attackButton1.Height);
            attackButton2.Location = new Point((this.Width * 1 / 3) - (attackButton2.Width / 2), this.Height - 125 - attackButton2.Height);
            attackButton3.Location = new Point((this.Width * 2 / 3) - (attackButton3.Width / 2), this.Height - 25 - attackButton3.Height);
            attackButton4.Location = new Point((this.Width * 1 / 3) - (attackButton4.Width / 2), this.Height - 25 - attackButton4.Height);
            backButton.Location = new Point((this.Width * 1 / 9) - (backButton.Width / 2), this.Height - 75 - backButton.Height);

            enemyHealthLabel.Width = enemy.sprite.Width;
            enemyHealthLabel.Location = new Point(this.Width * 4 / 5 - enemy.sprite.Width / 2, 25 + 2 * enemy.sprite.Height);

            // Hide the second set of buttons to start
            attackButton1.Visible = false;
            attackButton2.Visible = false;
            attackButton3.Visible = false;
            attackButton4.Visible = false;
            backButton.Visible = false;
        }

        // Reveal second set of buttons on click
        private void attackMenuButton_Click(object sender, EventArgs e)
        {
            // Hide first set of buttons
            inventoryButton.Visible = false;
            attackMenuButton.Visible = false;

            // Show second set
            attackButton1.Visible = true;
            attackButton2.Visible = true;
            attackButton3.Visible = true;
            attackButton4.Visible = true;
            backButton.Visible = true;
        }

        // Hide second set of buttons and reveal first
        private void backButton_Click(object sender, EventArgs e)
        {
            // Show first set of buttons
            inventoryButton.Visible = true;
            attackMenuButton.Visible = true;

            // Hide second set
            attackButton1.Visible = false;
            attackButton2.Visible = false;
            attackButton3.Visible = false;
            attackButton4.Visible = false;
            backButton.Visible = false;
        }

        private void CombatScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(whiteBrush, (this.Width - 1100) / 2, 50, 1100, 500);

            Image spr = enemy.sprite;
            e.Graphics.DrawImage(spr, this.Width * 4 / 5 - spr.Width / 2, 50 + spr.Height);

            e.Graphics.FillRectangle(greenBrush, this.Width * 4 / 5 - spr.Width / 2, 25 + 2 * spr.Height, spr.Width, 25);
            enemyHealthLabel.Text = $"{enemy.health} / {enemy.maxHealth}";
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
