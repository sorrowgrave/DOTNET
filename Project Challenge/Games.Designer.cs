namespace DrivingPXL
{
    partial class Games
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Games));
            this.dragNDropButton = new System.Windows.Forms.Button();
            this.memoryGameButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.returnLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dragNDropButton
            // 
            this.dragNDropButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dragNDropButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dragNDropButton.BackgroundImage")));
            this.dragNDropButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dragNDropButton.Location = new System.Drawing.Point(93, 117);
            this.dragNDropButton.Name = "dragNDropButton";
            this.dragNDropButton.Size = new System.Drawing.Size(310, 150);
            this.dragNDropButton.TabIndex = 3;
            this.dragNDropButton.UseVisualStyleBackColor = false;
            this.dragNDropButton.Click += new System.EventHandler(this.dragNDropButton_Click);
            // 
            // memoryGameButton
            // 
            this.memoryGameButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.memoryGameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("memoryGameButton.BackgroundImage")));
            this.memoryGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memoryGameButton.Location = new System.Drawing.Point(409, 117);
            this.memoryGameButton.Name = "memoryGameButton";
            this.memoryGameButton.Size = new System.Drawing.Size(310, 150);
            this.memoryGameButton.TabIndex = 4;
            this.memoryGameButton.UseVisualStyleBackColor = false;
            this.memoryGameButton.Click += new System.EventHandler(this.memoryClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(87, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(424, 32);
            this.label8.TabIndex = 20;
            this.label8.Text = "Choose a game you would like to play";
            // 
            // returnLabel
            // 
            this.returnLabel.BackColor = System.Drawing.Color.Transparent;
            this.returnLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.returnLabel.ForeColor = System.Drawing.Color.White;
            this.returnLabel.Image = ((System.Drawing.Image)(resources.GetObject("returnLabel.Image")));
            this.returnLabel.Location = new System.Drawing.Point(55, 51);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(30, 30);
            this.returnLabel.TabIndex = 19;
            this.returnLabel.Click += new System.EventHandler(this.returnLabel_Click);
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 330);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.memoryGameButton);
            this.Controls.Add(this.dragNDropButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(821, 330);
            this.Name = "Games";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dragNDropButton;
        private System.Windows.Forms.Button memoryGameButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label returnLabel;
    }
}