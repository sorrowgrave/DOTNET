namespace DrivingPXL
{
    partial class Results
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Results));
            this.userLabel = new System.Windows.Forms.Label();
            this.resultatenListBox = new System.Windows.Forms.ListBox();
            this.returnLabel = new System.Windows.Forms.Button();
            this.datumLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AllowDrop = true;
            this.userLabel.BackColor = System.Drawing.Color.Transparent;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.userLabel.ForeColor = System.Drawing.Color.White;
            this.userLabel.Location = new System.Drawing.Point(0, 31);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(821, 32);
            this.userLabel.TabIndex = 25;
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultatenListBox
            // 
            this.resultatenListBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.resultatenListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultatenListBox.ForeColor = System.Drawing.Color.White;
            this.resultatenListBox.FormattingEnabled = true;
            this.resultatenListBox.ItemHeight = 21;
            this.resultatenListBox.Location = new System.Drawing.Point(88, 134);
            this.resultatenListBox.Name = "resultatenListBox";
            this.resultatenListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultatenListBox.Size = new System.Drawing.Size(649, 214);
            this.resultatenListBox.TabIndex = 27;
            // 
            // returnLabel
            // 
            this.returnLabel.BackColor = System.Drawing.Color.Transparent;
            this.returnLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnLabel.FlatAppearance.BorderSize = 2;
            this.returnLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.returnLabel.ForeColor = System.Drawing.Color.White;
            this.returnLabel.Location = new System.Drawing.Point(54, 483);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(90, 32);
            this.returnLabel.TabIndex = 28;
            this.returnLabel.Text = "Return";
            this.returnLabel.UseVisualStyleBackColor = false;
            this.returnLabel.Click += new System.EventHandler(this.returnLabel_Click);
            this.returnLabel.MouseLeave += new System.EventHandler(this.returnLabel_MouseLeave);
            this.returnLabel.MouseHover += new System.EventHandler(this.returnLabel_MouseHover);
            // 
            // datumLabel
            // 
            this.datumLabel.BackColor = System.Drawing.Color.Transparent;
            this.datumLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumLabel.ForeColor = System.Drawing.Color.White;
            this.datumLabel.Location = new System.Drawing.Point(159, 106);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(123, 23);
            this.datumLabel.TabIndex = 29;
            this.datumLabel.Text = "Date and Time";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.pointsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.ForeColor = System.Drawing.Color.White;
            this.pointsLabel.Location = new System.Drawing.Point(307, 106);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(52, 21);
            this.pointsLabel.TabIndex = 30;
            this.pointsLabel.Text = "Score";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(487, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Comment";
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.datumLabel);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.resultatenListBox);
            this.Controls.Add(this.userLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Results";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.ListBox resultatenListBox;
        private System.Windows.Forms.Button returnLabel;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label label1;
    }
}