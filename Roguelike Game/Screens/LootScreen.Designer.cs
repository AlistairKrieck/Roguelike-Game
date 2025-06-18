namespace Roguelike_Game
{
    partial class LootScreen
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
            this.lootButton = new System.Windows.Forms.Button();
            this.xpRewardLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lootButton
            // 
            this.lootButton.Location = new System.Drawing.Point(262, 251);
            this.lootButton.Name = "lootButton";
            this.lootButton.Size = new System.Drawing.Size(356, 88);
            this.lootButton.TabIndex = 4;
            this.lootButton.Text = "Get Reward!";
            this.lootButton.UseVisualStyleBackColor = true;
            this.lootButton.Click += new System.EventHandler(this.lootButton_Click);
            // 
            // xpRewardLabel
            // 
            this.xpRewardLabel.BackColor = System.Drawing.Color.White;
            this.xpRewardLabel.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpRewardLabel.Location = new System.Drawing.Point(262, 80);
            this.xpRewardLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.xpRewardLabel.Name = "xpRewardLabel";
            this.xpRewardLabel.Size = new System.Drawing.Size(316, 227);
            this.xpRewardLabel.TabIndex = 5;
            this.xpRewardLabel.Text = "label1";
            this.xpRewardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LootScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.xpRewardLabel);
            this.Controls.Add(this.lootButton);
            this.DoubleBuffered = true;
            this.Name = "LootScreen";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.LootScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LootScreen_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lootButton;
        private System.Windows.Forms.Label xpRewardLabel;
    }
}
