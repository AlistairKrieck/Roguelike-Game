﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Roguelike_Game
{
    public partial class CombatScreen : UserControl
    {
        public static Enemy enemy;

        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush redBrush = new SolidBrush(Color.Red);

        bool playerTurn = true;

        // Stores which turn you are currently on
        int turnCount = 0;

        public CombatScreen()
        {
            InitializeComponent();
        }

        // Initilaze position of all components
        private void CombatScreen_Load(object sender, EventArgs e)
        {
            // Initialize positions of all labels and buttons
            inventoryButton.Location = new Point((this.Width - inventoryButton.Width) / 2, this.Height - 25 - inventoryButton.Height);
            attackMenuButton.Location = new Point((this.Width - attackMenuButton.Width) / 2, this.Height - 125 - attackMenuButton.Height);
            attackButton1.Location = new Point((this.Width * 1 / 3) - (attackButton1.Width / 2), this.Height - 125 - attackButton1.Height);
            attackButton2.Location = new Point((this.Width * 2 / 3) - (attackButton2.Width / 2), this.Height - 125 - attackButton2.Height);
            attackButton3.Location = new Point((this.Width * 1 / 3) - (attackButton3.Width / 2), this.Height - 25 - attackButton3.Height);
            attackButton4.Location = new Point((this.Width * 2 / 3) - (attackButton4.Width / 2), this.Height - 25 - attackButton4.Height);
            backButton.Location = new Point((this.Width * 1 / 9) - (backButton.Width / 2), this.Height - 75 - backButton.Height);

            enemyHealthLabel.Width = enemy.sprite.Width;
            enemyHealthLabel.Location = new Point(this.Width * 3 / 5 - enemy.sprite.Width / 2, 25 + 2 * enemy.sprite.Height);

            playerHealthLabel.Width = Form1.player.sprite.Width;
            playerHealthLabel.Location = new Point(this.Width * 1 / 5 - Form1.player.sprite.Width / 2, 115 + 2 * Form1.player.sprite.Height);

            pastMovesLabel.Location = new Point(this.Width - 125 - (pastMovesLabel.Width / 2), 100);

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
            // White rectangle that the sprites are inside of
            e.Graphics.FillRectangle(whiteBrush, (this.Width - 900) / 2 - 100, 50, 900, 500);

            // Draw the enemy
            Image spr = enemy.sprite;
            e.Graphics.DrawImage(spr, this.Width * 3 / 5 - spr.Width / 2, 50 + spr.Height);

            // Display the enemy health
            e.Graphics.FillRectangle(redBrush, this.Width * 3 / 5 - spr.Width / 2, 25 + 2 * spr.Height, spr.Width, 25);
            e.Graphics.FillRectangle(greenBrush, this.Width * 3 / 5 - spr.Width / 2, 25 + 2 * spr.Height, spr.Width * enemy.hp / enemy.maxHp, 25);
            enemyHealthLabel.Text = $"{enemy.hp} / {enemy.maxHp}";

            // Draw the player
            Image pSpr = Form1.player.sprite;
            e.Graphics.DrawImage(pSpr, this.Width * 1 / 5 - pSpr.Width / 2, 200 + spr.Height);

            // Display the player health
            e.Graphics.FillRectangle(redBrush, this.Width * 1 / 5 - pSpr.Width / 2, 115 + 2 * pSpr.Height, pSpr.Width, 25);
            e.Graphics.FillRectangle(greenBrush, this.Width * 1 / 5 - pSpr.Width / 2, 115 + 2 * pSpr.Height, pSpr.Width * Form1.player.hp / Form1.player.maxHp, 25);
            playerHealthLabel.Text = $"{Form1.player.hp} / {Form1.player.maxHp}";

            // Show the name and power points of each of the player's attacks
            attackButton1.Text = $"{Form1.player.attacks[0].name}\nPP:{Form1.player.attacks[0].pp} / {Form1.player.attacks[0].ppMax}";
            attackButton2.Text = $"{Form1.player.attacks[1].name}\nPP:{Form1.player.attacks[1].pp} / {Form1.player.attacks[1].ppMax}";
            attackButton3.Text = $"{Form1.player.attacks[2].name}\nPP:{Form1.player.attacks[2].pp} / {Form1.player.attacks[2].ppMax}";
            attackButton4.Text = $"{Form1.player.attacks[3].name}\nPP:{Form1.player.attacks[3].pp} / {Form1.player.attacks[3].ppMax}";
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (playerTurn == false)
            {
                Refresh();

                // Temp
                // Wait to make the game less snappy
                Thread.Sleep(500);

                EnemyAttack();

                // Increment the turn by 1 whenever the enemy uses their attack
                turnCount++;

                // Add a line break between each turn
                pastMovesLabel.Items.Add("", 0);

                // Re-enable the buttons after the UseAttack method
                attackButton1.Enabled = true;
                attackButton2.Enabled = true;
                attackButton3.Enabled = true;
                attackButton4.Enabled = true;
                backButton.Enabled = true;
            }

            Refresh();
        }

        private void UseAttack(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            // Find which attack was used by the player based on the button they pressed
            Attack a = Form1.player.attacks[Convert.ToInt32(b.Name.Substring(12)) - 1];

            // Stop the player from using an attack if it's out off pp
            if (a.pp <= 0)
            {
                return;
            }

            // Reduce used attacks power points by 1
            a.pp--;

            // If the enemy is not dead, reduce enemy health
            if (enemy.hp - a.damage > 0)
            {
                enemy.hp -= a.damage;
            }

            // If the enemy dies, reset pp and switch to relevant screen
            else if (enemy.hp - a.damage <= 0)
            {
                gameTimer.Stop();

                enemy.hp -= a.damage;

                Refresh();
                Thread.Sleep(500);

                // Reset power points for all player attacks
                foreach (Attack atk in Form1.player.attacks)
                {
                    atk.pp = atk.ppMax;
                }

                // if the bass is beaten, go to the win screen
                if (enemy is BossEnemy)
                {
                    Form1.ChangeScreen(this, new WinScreen());
                }
                // if the enemy was not the boss, go to the loot screen
                else
                {
                    Form1.ChangeScreen(this, new LootScreen());
                }
            }

            // Heal player when using the "Heal" attack
            if (a is PlayerHeal)
            {
                PlayerHeal h = (PlayerHeal)a;

                // Prevent healing from going over max health
                if (Form1.player.hp + h.healing <= Form1.player.maxHp)
                {
                    Form1.player.hp += h.healing;
                }
                else
                {
                    Form1.player.hp = Form1.player.maxHp;
                }
            }

            pastMovesLabel.Items.Add(GetTurnInfo(a));

            // Disable buttons to prevent their use during the enemy turn
            attackButton1.Enabled = false;
            attackButton2.Enabled = false;
            attackButton3.Enabled = false;
            attackButton4.Enabled = false;
            backButton.Enabled = false;

            // Tell the game the player has used their move
            playerTurn = false;
        }

        private void EnemyAttack()
        {
            Attack a = enemy.Attack();

            // Reduce player health
            if (Form1.player.hp - a.damage > 0)
            {
                Form1.player.hp -= a.damage;
            }

            // If the player dies, go to the game over screen (name didn't update when I changed it :/)
            else if (Form1.player.hp - a.damage <= 0)
            {
                Form1.player.hp -= a.damage;
                Form1.ChangeScreen(this, new WinScreen());
            }

            // Increase enemy health if they use a heal
            if (a is EnemyHeal)
            {
                EnemyHeal h = (EnemyHeal)a;

                // Increase enemy health by healing amount
                if (enemy.hp + h.healing <= enemy.maxHp)
                {
                    enemy.hp += h.healing;
                }

                // If healing amount would push max hp above 1, just set hp to max
                else
                {
                    enemy.hp = enemy.maxHp;
                }
            }

            // Add what the enemy did to the past turns display
            pastMovesLabel.Items.Add(GetTurnInfo(a));

            // Allow the player to take their next turn
            playerTurn = true;
        }

        // Returns a new list view item storing what happened on the current turn
        private ListViewItem GetTurnInfo(Attack atk)
        {
            ListViewItem turn;

            // Get the turn number, which move was used, and how much damage it dealt
            if (playerTurn)
            {
                turn = new ListViewItem($"Turn {turnCount}: You used {atk.name} for {atk.damage} dmg!", 0);
            }

            // If it was the enemy's turn, also include the remaining pp of the attack
            else
            {
                turn = new ListViewItem($"Turn {turnCount}: Enemy used {atk.name} for {atk.damage} dmg!  PP: {atk.pp} / {atk.ppMax}", 0);
            }

            // Send the new item to the list view to be displayed
            return turn;
        }

        private void CombatScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
