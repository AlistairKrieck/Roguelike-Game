namespace Roguelike_Game
{
    partial class CombatScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.attackMenuButton = new System.Windows.Forms.Button();
            this.attackButton1 = new System.Windows.Forms.Button();
            this.attackButton2 = new System.Windows.Forms.Button();
            this.attackButton4 = new System.Windows.Forms.Button();
            this.attackButton3 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyHealthLabel = new System.Windows.Forms.Label();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inventoryButton
            // 
            this.inventoryButton.Location = new System.Drawing.Point(266, 569);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(615, 88);
            this.inventoryButton.TabIndex = 0;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = true;
            // 
            // attackMenuButton
            // 
            this.attackMenuButton.Location = new System.Drawing.Point(266, 455);
            this.attackMenuButton.Name = "attackMenuButton";
            this.attackMenuButton.Size = new System.Drawing.Size(615, 88);
            this.attackMenuButton.TabIndex = 1;
            this.attackMenuButton.Text = "Attack";
            this.attackMenuButton.UseVisualStyleBackColor = true;
            this.attackMenuButton.Click += new System.EventHandler(this.attackMenuButton_Click);
            // 
            // attackButton1
            // 
            this.attackButton1.Location = new System.Drawing.Point(72, 257);
            this.attackButton1.Name = "attackButton1";
            this.attackButton1.Size = new System.Drawing.Size(356, 88);
            this.attackButton1.TabIndex = 2;
            this.attackButton1.Text = "Attack";
            this.attackButton1.UseVisualStyleBackColor = true;
            this.attackButton1.Click += new System.EventHandler(this.UseAttack);
            // 
            // attackButton2
            // 
            this.attackButton2.Location = new System.Drawing.Point(434, 257);
            this.attackButton2.Name = "attackButton2";
            this.attackButton2.Size = new System.Drawing.Size(356, 88);
            this.attackButton2.TabIndex = 3;
            this.attackButton2.Text = "Attack";
            this.attackButton2.UseVisualStyleBackColor = true;
            this.attackButton2.Click += new System.EventHandler(this.UseAttack);
            // 
            // attackButton4
            // 
            this.attackButton4.Location = new System.Drawing.Point(434, 351);
            this.attackButton4.Name = "attackButton4";
            this.attackButton4.Size = new System.Drawing.Size(356, 88);
            this.attackButton4.TabIndex = 4;
            this.attackButton4.Text = "Attack";
            this.attackButton4.UseVisualStyleBackColor = true;
            this.attackButton4.Click += new System.EventHandler(this.UseAttack);
            // 
            // attackButton3
            // 
            this.attackButton3.Location = new System.Drawing.Point(72, 351);
            this.attackButton3.Name = "attackButton3";
            this.attackButton3.Size = new System.Drawing.Size(356, 88);
            this.attackButton3.TabIndex = 5;
            this.attackButton3.Text = "Attack";
            this.attackButton3.UseVisualStyleBackColor = true;
            this.attackButton3.Click += new System.EventHandler(this.UseAttack);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(796, 306);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(97, 88);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // enemyHealthLabel
            // 
            this.enemyHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.enemyHealthLabel.Location = new System.Drawing.Point(384, 86);
            this.enemyHealthLabel.Name = "enemyHealthLabel";
            this.enemyHealthLabel.Size = new System.Drawing.Size(100, 25);
            this.enemyHealthLabel.TabIndex = 7;
            this.enemyHealthLabel.Text = "number";
            this.enemyHealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerHealthLabel.Location = new System.Drawing.Point(570, 149);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(100, 25);
            this.playerHealthLabel.TabIndex = 8;
            this.playerHealthLabel.Text = "number";
            this.playerHealthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CombatScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.playerHealthLabel);
            this.Controls.Add(this.enemyHealthLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.attackButton3);
            this.Controls.Add(this.attackButton4);
            this.Controls.Add(this.attackButton2);
            this.Controls.Add(this.attackButton1);
            this.Controls.Add(this.attackMenuButton);
            this.Controls.Add(this.inventoryButton);
            this.DoubleBuffered = true;
            this.Name = "CombatScreen";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.CombatScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CombatScreen_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Button attackMenuButton;
        private System.Windows.Forms.Button attackButton1;
        private System.Windows.Forms.Button attackButton2;
        private System.Windows.Forms.Button attackButton4;
        private System.Windows.Forms.Button attackButton3;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label enemyHealthLabel;
        private System.Windows.Forms.Label playerHealthLabel;
    }
}
