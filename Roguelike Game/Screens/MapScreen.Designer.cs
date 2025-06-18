namespace Roguelike_Game
{
    partial class MapScreen
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
            this.hpLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.xpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hpLabel
            // 
            this.hpLabel.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpLabel.ForeColor = System.Drawing.Color.White;
            this.hpLabel.Location = new System.Drawing.Point(502, 12);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(184, 23);
            this.hpLabel.TabIndex = 0;
            this.hpLabel.Text = "label1";
            this.hpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // levelLabel
            // 
            this.levelLabel.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.White;
            this.levelLabel.Location = new System.Drawing.Point(502, 35);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(184, 23);
            this.levelLabel.TabIndex = 1;
            this.levelLabel.Text = "label1";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // xpLabel
            // 
            this.xpLabel.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpLabel.ForeColor = System.Drawing.Color.White;
            this.xpLabel.Location = new System.Drawing.Point(502, 58);
            this.xpLabel.Name = "xpLabel";
            this.xpLabel.Size = new System.Drawing.Size(184, 23);
            this.xpLabel.TabIndex = 2;
            this.xpLabel.Text = "label1";
            this.xpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MapScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.xpLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.hpLabel);
            this.DoubleBuffered = true;
            this.Name = "MapScreen";
            this.Size = new System.Drawing.Size(700, 850);
            this.Click += new System.EventHandler(this.MapScreen_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MapScreen_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label xpLabel;
    }
}
