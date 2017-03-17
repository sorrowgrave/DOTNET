namespace BasicSec04
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.startLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.tijdLabel = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.minimizeLabel2 = new System.Windows.Forms.Label();
            this.expandLabel2 = new System.Windows.Forms.Label();
            this.minimizeLabel = new System.Windows.Forms.Label();
            this.expandLabel = new System.Windows.Forms.Label();
            this.closeLabel2 = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.changePictureLabel = new System.Windows.Forms.Label();
            this.signOutLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.timerCredits = new System.Windows.Forms.Timer(this.components);
            this.tijdTimer = new System.Windows.Forms.Timer(this.components);
            this.SteganographyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // encryptButton
            // 
            this.encryptButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.encryptButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("encryptButton.BackgroundImage")));
            this.encryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encryptButton.Location = new System.Drawing.Point(101, 114);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(310, 150);
            this.encryptButton.TabIndex = 0;
            this.encryptButton.UseVisualStyleBackColor = false;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.decryptButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("decryptButton.BackgroundImage")));
            this.decryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decryptButton.Location = new System.Drawing.Point(417, 114);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(310, 150);
            this.decryptButton.TabIndex = 1;
            this.decryptButton.UseVisualStyleBackColor = false;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.White;
            this.startLabel.Location = new System.Drawing.Point(68, 50);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(72, 37);
            this.startLabel.TabIndex = 4;
            this.startLabel.Text = "Start";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(541, 27);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usernameLabel.Size = new System.Drawing.Size(175, 50);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tijdLabel
            // 
            this.tijdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tijdLabel.AutoSize = true;
            this.tijdLabel.BackColor = System.Drawing.Color.Transparent;
            this.tijdLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tijdLabel.ForeColor = System.Drawing.Color.White;
            this.tijdLabel.Location = new System.Drawing.Point(702, 501);
            this.tijdLabel.Name = "tijdLabel";
            this.tijdLabel.Size = new System.Drawing.Size(107, 30);
            this.tijdLabel.TabIndex = 8;
            this.tijdLabel.Text = "HH:mm:ss";
            // 
            // closeLabel
            // 
            this.closeLabel.BackColor = System.Drawing.Color.Transparent;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Image = ((System.Drawing.Image)(resources.GetObject("closeLabel.Image")));
            this.closeLabel.Location = new System.Drawing.Point(16, 9);
            this.closeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(14, 14);
            this.closeLabel.TabIndex = 9;
            this.closeLabel.MouseHover += new System.EventHandler(this.sluitLabel_MouseHover);
            // 
            // minimizeLabel2
            // 
            this.minimizeLabel2.BackColor = System.Drawing.Color.Transparent;
            this.minimizeLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeLabel2.Image = ((System.Drawing.Image)(resources.GetObject("minimizeLabel2.Image")));
            this.minimizeLabel2.Location = new System.Drawing.Point(37, 9);
            this.minimizeLabel2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.minimizeLabel2.Name = "minimizeLabel2";
            this.minimizeLabel2.Size = new System.Drawing.Size(14, 14);
            this.minimizeLabel2.TabIndex = 10;
            this.minimizeLabel2.MouseHover += new System.EventHandler(this.minimizeLabel_MouseHover);
            // 
            // expandLabel2
            // 
            this.expandLabel2.BackColor = System.Drawing.Color.Transparent;
            this.expandLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expandLabel2.Image = ((System.Drawing.Image)(resources.GetObject("expandLabel2.Image")));
            this.expandLabel2.Location = new System.Drawing.Point(58, 9);
            this.expandLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.expandLabel2.Name = "expandLabel2";
            this.expandLabel2.Size = new System.Drawing.Size(14, 14);
            this.expandLabel2.TabIndex = 11;
            this.expandLabel2.MouseHover += new System.EventHandler(this.expandLabel_MouseHover);
            // 
            // minimizeLabel
            // 
            this.minimizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.minimizeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeLabel.Image = ((System.Drawing.Image)(resources.GetObject("minimizeLabel.Image")));
            this.minimizeLabel.Location = new System.Drawing.Point(37, 9);
            this.minimizeLabel.Name = "minimizeLabel";
            this.minimizeLabel.Size = new System.Drawing.Size(14, 14);
            this.minimizeLabel.TabIndex = 12;
            this.minimizeLabel.Visible = false;
            this.minimizeLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minimizeLabel2_MouseClick);
            this.minimizeLabel.MouseLeave += new System.EventHandler(this.minimizeLabel2_MouseLeave);
            // 
            // expandLabel
            // 
            this.expandLabel.BackColor = System.Drawing.Color.Transparent;
            this.expandLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expandLabel.Image = ((System.Drawing.Image)(resources.GetObject("expandLabel.Image")));
            this.expandLabel.Location = new System.Drawing.Point(58, 9);
            this.expandLabel.Margin = new System.Windows.Forms.Padding(0);
            this.expandLabel.Name = "expandLabel";
            this.expandLabel.Size = new System.Drawing.Size(14, 14);
            this.expandLabel.TabIndex = 13;
            this.expandLabel.Visible = false;
            this.expandLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.expandLabel2_MouseClick);
            this.expandLabel.MouseLeave += new System.EventHandler(this.expandLabel2_MouseLeave);
            // 
            // closeLabel2
            // 
            this.closeLabel2.BackColor = System.Drawing.Color.Transparent;
            this.closeLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel2.Image = ((System.Drawing.Image)(resources.GetObject("closeLabel2.Image")));
            this.closeLabel2.Location = new System.Drawing.Point(15, 9);
            this.closeLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.closeLabel2.Name = "closeLabel2";
            this.closeLabel2.Size = new System.Drawing.Size(14, 14);
            this.closeLabel2.TabIndex = 14;
            this.closeLabel2.Visible = false;
            this.closeLabel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeLabel2_MouseClick);
            this.closeLabel2.MouseLeave += new System.EventHandler(this.closeLabel2_MouseLeave);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profilePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.profilePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profilePictureBox.BackgroundImage")));
            this.profilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePictureBox.Location = new System.Drawing.Point(726, 17);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(75, 75);
            this.profilePictureBox.TabIndex = 15;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.profilePictureBox_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // changePictureLabel
            // 
            this.changePictureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changePictureLabel.BackColor = System.Drawing.Color.White;
            this.changePictureLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePictureLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePictureLabel.ForeColor = System.Drawing.Color.DimGray;
            this.changePictureLabel.Location = new System.Drawing.Point(621, 95);
            this.changePictureLabel.Name = "changePictureLabel";
            this.changePictureLabel.Size = new System.Drawing.Size(180, 39);
            this.changePictureLabel.TabIndex = 16;
            this.changePictureLabel.Text = "  Change account picture";
            this.changePictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePictureLabel.Visible = false;
            this.changePictureLabel.Click += new System.EventHandler(this.changePictureLabel_Click);
            this.changePictureLabel.MouseLeave += new System.EventHandler(this.changePictureLabel_MouseLeave);
            this.changePictureLabel.MouseHover += new System.EventHandler(this.changePictureLabel_MouseHover);
            // 
            // signOutLabel
            // 
            this.signOutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.signOutLabel.BackColor = System.Drawing.Color.White;
            this.signOutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutLabel.ForeColor = System.Drawing.Color.DimGray;
            this.signOutLabel.Location = new System.Drawing.Point(621, 134);
            this.signOutLabel.Name = "signOutLabel";
            this.signOutLabel.Size = new System.Drawing.Size(180, 39);
            this.signOutLabel.TabIndex = 17;
            this.signOutLabel.Text = "  Sign out";
            this.signOutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signOutLabel.Visible = false;
            this.signOutLabel.Click += new System.EventHandler(this.signOutLabel_Click);
            this.signOutLabel.MouseLeave += new System.EventHandler(this.signOutLabel_MouseLeave);
            this.signOutLabel.MouseHover += new System.EventHandler(this.signOutLabel_MouseHover);
            // 
            // exitLabel
            // 
            this.exitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitLabel.BackColor = System.Drawing.Color.White;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.DimGray;
            this.exitLabel.Location = new System.Drawing.Point(621, 173);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(180, 39);
            this.exitLabel.TabIndex = 18;
            this.exitLabel.Text = "  Exit";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitLabel.Visible = false;
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            this.exitLabel.MouseLeave += new System.EventHandler(this.exitLabel_MouseLeave);
            this.exitLabel.MouseHover += new System.EventHandler(this.exitLabel_MouseHover);
            // 
            // tijdTimer
            // 
            this.tijdTimer.Tick += new System.EventHandler(this.tijdTimer_Tick);
            // 
            // SteganographyButton
            // 
            this.SteganographyButton.BackColor = System.Drawing.Color.DimGray;
            this.SteganographyButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SteganographyButton.BackgroundImage")));
            this.SteganographyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SteganographyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SteganographyButton.Location = new System.Drawing.Point(101, 270);
            this.SteganographyButton.Name = "SteganographyButton";
            this.SteganographyButton.Size = new System.Drawing.Size(310, 150);
            this.SteganographyButton.TabIndex = 20;
            this.SteganographyButton.UseVisualStyleBackColor = false;
            this.SteganographyButton.Click += new System.EventHandler(this.SteganographyButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 559);
            this.Controls.Add(this.SteganographyButton);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.signOutLabel);
            this.Controls.Add(this.changePictureLabel);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.closeLabel2);
            this.Controls.Add(this.expandLabel);
            this.Controls.Add(this.minimizeLabel);
            this.Controls.Add(this.expandLabel2);
            this.Controls.Add(this.minimizeLabel2);
            this.Controls.Add(this.closeLabel);
            this.Controls.Add(this.tijdLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.MouseHover += new System.EventHandler(this.Menu_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label tijdLabel;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label minimizeLabel2;
        private System.Windows.Forms.Label expandLabel2;
        private System.Windows.Forms.Label minimizeLabel;
        private System.Windows.Forms.Label expandLabel;
        private System.Windows.Forms.Label closeLabel2;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label changePictureLabel;
        private System.Windows.Forms.Label signOutLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Timer timerCredits;
        private System.Windows.Forms.Timer tijdTimer;
        private System.Windows.Forms.Button SteganographyButton;
    }
}