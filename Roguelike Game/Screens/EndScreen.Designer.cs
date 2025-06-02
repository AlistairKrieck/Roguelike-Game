namespace Roguelike_Game
{
    partial class EndScreen
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
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(336, 138);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(229, 67);
            this.mainMenuButton.TabIndex = 0;
            this.mainMenuButton.Text = "Back To Menu";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(336, 211);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(229, 67);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mainMenuButton);
            this.Name = "EndScreen";
            this.Size = new System.Drawing.Size(1200, 800);
            this.Load += new System.EventHandler(this.MenuScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Button exitButton;
    }
}
