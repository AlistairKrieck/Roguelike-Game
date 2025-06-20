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

            // Find the loot the player has recieved based on what enemy they just defeated
            GetLoot();

            // Draw the screen once
            Refresh();
        }

        // Init the position of the labels
        private void LootScreen_Load(object sender, EventArgs e)
        {
            lootButton.Location = new Point((this.Width - lootButton.Width) / 2, this.Height - 25 - lootButton.Height);

            xpRewardLabel.Location = new Point((this.Width - xpRewardLabel.Width) / 2, 50);
        }

        // Find the xp the player was rewarded by the defeated enemy
        public void GetLoot()
        {
            // Get the enemy from combat screen
            Enemy enemy = CombatScreen.enemy;

            // Store the amount of xp the enemy rewarded
            xpReward = enemy.xpReward;

            // Tell the player how much xp they earned
            xpRewardLabel.Text = $"You Gained {xpReward} XP!";

            // Tell the player if they leveled up
            if (Form1.player.xp + xpReward >= Form1.player.xpToNextLevel[Form1.player.level])
            {
                xpRewardLabel.Text += $"\n";
                xpRewardLabel.Text += $"\nYou Leveled Up!";
                xpRewardLabel.Text += $"\n+3 to Max HP!";
                xpRewardLabel.Text += $"\n+2 PP to All Attacks!";
                xpRewardLabel.Text += $"\nYou Fully Healed!";

                // Tell the player if they learned any new moves
                if (Form1.player.level == 0)
                {
                    xpRewardLabel.Text += $"\nYou Learned 'Heal!'";
                }
                if (Form1.player.level == 1)
                {
                    xpRewardLabel.Text += $"\nYou Learned 'Big Bash!'";
                }
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

            // Go back to the map
            Form1.ChangeScreen(this, new MapScreen());
        }

        private void LootScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
