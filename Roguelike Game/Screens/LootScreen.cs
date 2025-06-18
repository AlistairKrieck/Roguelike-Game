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
    public partial class LootScreen : UserControl
    {
        public static int xpReward;

        public LootScreen()
        {
            InitializeComponent();

            GetLoot();

            Refresh();
        }


        private void LootScreen_Load(object sender, EventArgs e)
        {
            lootButton.Location = new Point((this.Width - lootButton.Width) / 2, this.Height - 25 - lootButton.Height);

            xpRewardLabel.Location = new Point((this.Width - xpRewardLabel.Width) / 2, (this.Height * 1 / 5) - (xpRewardLabel.Height / 2));
        }


        public void GetLoot()
        {
            Enemy enemy = CombatScreen.enemy;

            xpReward = enemy.xpReward;

            xpRewardLabel.Text = $"You Gained {xpReward} XP!";

            if (Form1.player.xp + xpReward >= Form1.player.xpToNextLevel[Form1.player.level])
            {
                xpRewardLabel.Text += $"\n";
                xpRewardLabel.Text += $"\nYou Leveled Up!";
                xpRewardLabel.Text += $"\n+3 to Max HP!";
                xpRewardLabel.Text += $"\n+2 PP to All Attacks!";
                xpRewardLabel.Text += $"\nYou Fully Healed!";
            }
        }


        private void LootScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.White), (this.Width - 1100) / 2, 50, 1100, 500);
        }

        private void lootButton_Click(object sender, EventArgs e)
        {
            // Give the player their xp
            Form1.player.xp += xpReward;

            // Level up the player if xp meets requirement
            Form1.player.CheckLevelUp();

            Form1.ChangeScreen(this, new MapScreen());
        }
    }
}
