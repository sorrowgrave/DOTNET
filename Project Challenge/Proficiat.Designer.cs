namespace DrivingPXL
{
    partial class Proficiat
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proficiat));
            this.proficiatLabel = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Button();
            this.playLabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // proficiatLabel
            // 
            this.proficiatLabel.BackColor = System.Drawing.Color.Transparent;
            this.proficiatLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proficiatLabel.ForeColor = System.Drawing.Color.White;
            this.proficiatLabel.Location = new System.Drawing.Point(50, 25);
            this.proficiatLabel.Name = "proficiatLabel";
            this.proficiatLabel.Size = new System.Drawing.Size(273, 45);
            this.proficiatLabel.TabIndex = 0;
            this.proficiatLabel.Text = "Proficiat alle antwoorden waren correct,  wat wenst u nu te doen?";
            this.proficiatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuLabel
            // 
            this.menuLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuLabel.FlatAppearance.BorderSize = 2;
            this.menuLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuLabel.ForeColor = System.Drawing.Color.White;
            this.menuLabel.Location = new System.Drawing.Point(200, 93);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(124, 32);
            this.menuLabel.TabIndex = 50;
            this.menuLabel.Text = "Go to menu";
            this.menuLabel.UseVisualStyleBackColor = false;
            this.menuLabel.Click += new System.EventHandler(this.menuLabel_Click);
            this.menuLabel.MouseLeave += new System.EventHandler(this.menuLabel_MouseLeave);
            this.menuLabel.MouseHover += new System.EventHandler(this.menuLabel_MouseHover);
            // 
            // playLabel
            // 
            this.playLabel.BackColor = System.Drawing.Color.Transparent;
            this.playLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playLabel.FlatAppearance.BorderSize = 2;
            this.playLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.playLabel.ForeColor = System.Drawing.Color.White;
            this.playLabel.Location = new System.Drawing.Point(53, 93);
            this.playLabel.Name = "playLabel";
            this.playLabel.Size = new System.Drawing.Size(124, 32);
            this.playLabel.TabIndex = 51;
            this.playLabel.Text = "Play again";
            this.playLabel.UseVisualStyleBackColor = false;
            this.playLabel.Click += new System.EventHandler(this.playLabel_Click);
            this.playLabel.MouseLeave += new System.EventHandler(this.playLabel_MouseLeave);
            this.playLabel.MouseHover += new System.EventHandler(this.playLabel_MouseHover);
            // 
            // Proficiat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(380, 173);
            this.Controls.Add(this.playLabel);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.proficiatLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 173);
            this.Name = "Proficiat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proficiat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label proficiatLabel;
        private System.Windows.Forms.Button menuLabel;
        private System.Windows.Forms.Button playLabel;
    }
}