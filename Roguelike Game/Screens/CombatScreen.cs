using System;
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

        public CombatScreen()
        {
            InitializeComponent();

            enemy = new SmallEnemy();
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
            enemyHealthLabel.Location = new Point(this.Width * 4 / 5 - enemy.sprite.Width / 2, 25 + 2 * enemy.sprite.Height);

            playerHealthLabel.Width = Form1.player.sprite.Width;
            playerHealthLabel.Location = new Point(this.Width * 1 / 5 - Form1.player.sprite.Width / 2, 115 + 2 * Form1.player.sprite.Height);

            // Init text and hide the second set of buttons to start
            attackButton1.Visible = false;
            attackButton1.Text = Form1.player.attacks[0].name;

            attackButton2.Visible = false;
            attackButton2.Text = Form1.player.attacks[1].name;

            attackButton3.Visible = false;
            attackButton4.Visible = false;

            // If the attacks do not exist, set text to empty
            try
            {
                attackButton3.Text = Form1.player.attacks[2].name;
            }
            catch
            {
                attackButton3.Text = "";
            }

            try
            {

                attackButton4.Text = Form1.player.attacks[3].name;
            }
            catch
            {
                attackButton4.Text = "";
            }

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

            // Display the enemy health
            e.Graphics.FillRectangle(redBrush, this.Width * 4 / 5 - spr.Width / 2, 25 + 2 * spr.Height, spr.Width, 25);
            e.Graphics.FillRectangle(greenBrush, this.Width * 4 / 5 - spr.Width / 2, 25 + 2 * spr.Height, spr.Width * enemy.health / enemy.maxHealth, 25);
            enemyHealthLabel.Text = $"{enemy.health} / {enemy.maxHealth}";

            // Draw the player
            Image pSpr = Form1.player.sprite;
            e.Graphics.DrawImage(pSpr, this.Width * 1 / 5 - pSpr.Width / 2, 200 + spr.Height);

            // Display the player health
            e.Graphics.FillRectangle(redBrush, this.Width * 1 / 5 - pSpr.Width / 2, 115 + 2 * pSpr.Height, pSpr.Width, 25);
            e.Graphics.FillRectangle(greenBrush, this.Width * 1 / 5 - pSpr.Width / 2, 115 + 2 * pSpr.Height, pSpr.Width * Form1.player.hp / Form1.player.maxHp, 25);
            playerHealthLabel.Text = $"{Form1.player.hp} / {Form1.player.maxHp}";
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (playerTurn == false)
            {
                Refresh();

                //Temp wait to make the game less instant
                Thread.Sleep(500);

                EnemyAttack();

                playerTurn = true;
            }


            Refresh();
        }

        private void UseAttack(object sender, EventArgs e)
        {
            playerTurn = false;

            Button b = (Button)sender;

            int atk = Convert.ToInt32(b.Name.Substring(12));

            if (enemy.health - Form1.player.attacks[atk - 1].damage > 0)
            {
                enemy.health -= Form1.player.attacks[atk - 1].damage;
            }

            else if (enemy.health - Form1.player.attacks[atk - 1].damage <= 0)
            {
                gameTimer.Stop();

                enemy.OnDeath();

                Form1.player.CheckLevelUp();

                Form1.ChangeScreen(this, new MapScreen());
            }

            if (Form1.player.attacks[atk - 1] is Heal)
            {
                Heal h = (Heal)Form1.player.attacks[atk - 1];

                if (Form1.player.hp + h.healing <= Form1.player.maxHp)
                {
                    Form1.player.hp += h.healing;
                }
                else
                {
                    Form1.player.hp = Form1.player.maxHp;
                }
            }
        }

        private void EnemyAttack()
        {
            Attack a = enemy.Attack();

            if (Form1.player.hp - a.damage > 0)
            {
                Form1.player.hp -= a.damage;
            }

            else if (Form1.player.hp - a.damage <= 0)
            {
                Form1.ChangeScreen(this, new EndScreen());
            }
        }
    }
}
