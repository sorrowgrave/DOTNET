namespace DrivingPXL
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
            this.examenBtn = new System.Windows.Forms.Button();
            this.oefenButton = new System.Windows.Forms.Button();
            this.gamesButton = new System.Windows.Forms.Button();
            this.resultatenBtn = new System.Windows.Forms.Button();
            this.startLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.timerTijd = new System.Windows.Forms.Timer(this.components);
            this.tijdLbl = new System.Windows.Forms.Label();
            this.sluitLbl = new System.Windows.Forms.Label();
            this.minLbl = new System.Windows.Forms.Label();
            this.plusLbl = new System.Windows.Forms.Label();
            this.minLbl2 = new System.Windows.Forms.Label();
            this.plusLbl2 = new System.Windows.Forms.Label();
            this.sluitLbl2 = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.changePictureLabel = new System.Windows.Forms.Label();
            this.signOutLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.timerCredits = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // examenBtn
            // 
            this.examenBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.examenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("examenBtn.BackgroundImage")));
            this.examenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.examenBtn.Location = new System.Drawing.Point(75, 125);
            this.examenBtn.Name = "examenBtn";
            this.examenBtn.Size = new System.Drawing.Size(310, 150);
            this.examenBtn.TabIndex = 0;
            this.examenBtn.UseVisualStyleBackColor = false;
            this.examenBtn.Click += new System.EventHandler(this.examenBtn_Click);
            // 
            // oefenButton
            // 
            this.oefenButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.oefenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("oefenButton.BackgroundImage")));
            this.oefenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oefenButton.Location = new System.Drawing.Point(391, 125);
            this.oefenButton.Name = "oefenButton";
            this.oefenButton.Size = new System.Drawing.Size(310, 150);
            this.oefenButton.TabIndex = 1;
            this.oefenButton.UseVisualStyleBackColor = false;
            this.oefenButton.Click += new System.EventHandler(this.oefenButton_Click);
            // 
            // gamesButton
            // 
            this.gamesButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gamesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gamesButton.BackgroundImage")));
            this.gamesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gamesButton.Location = new System.Drawing.Point(391, 281);
            this.gamesButton.Name = "gamesButton";
            this.gamesButton.Size = new System.Drawing.Size(310, 150);
            this.gamesButton.TabIndex = 3;
            this.gamesButton.UseVisualStyleBackColor = false;
            this.gamesButton.Click += new System.EventHandler(this.gamesBtn_Click);
            // 
            // resultatenBtn
            // 
            this.resultatenBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resultatenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resultatenBtn.BackgroundImage")));
            this.resultatenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resultatenBtn.Location = new System.Drawing.Point(75, 281);
            this.resultatenBtn.Name = "resultatenBtn";
            this.resultatenBtn.Size = new System.Drawing.Size(310, 150);
            this.resultatenBtn.TabIndex = 2;
            this.resultatenBtn.UseVisualStyleBackColor = false;
            this.resultatenBtn.Click += new System.EventHandler(this.resultatenBtn_Click);
            // 
            // startLbl
            // 
            this.startLbl.AutoSize = true;
            this.startLbl.BackColor = System.Drawing.Color.Transparent;
            this.startLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLbl.ForeColor = System.Drawing.Color.White;
            this.startLbl.Location = new System.Drawing.Point(68, 50);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(72, 37);
            this.startLbl.TabIndex = 4;
            this.startLbl.Text = "Start";
            // 
            // usernameLbl
            // 
            this.usernameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(541, 27);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usernameLbl.Size = new System.Drawing.Size(175, 50);
            this.usernameLbl.TabIndex = 6;
            this.usernameLbl.Text = "Username";
            this.usernameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerTijd
            // 
            this.timerTijd.Tick += new System.EventHandler(this.timerTijd_Tick);
            // 
            // tijdLbl
            // 
            this.tijdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tijdLbl.AutoSize = true;
            this.tijdLbl.BackColor = System.Drawing.Color.Transparent;
            this.tijdLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tijdLbl.Location = new System.Drawing.Point(702, 501);
            this.tijdLbl.Name = "tijdLbl";
            this.tijdLbl.Size = new System.Drawing.Size(107, 30);
            this.tijdLbl.TabIndex = 8;
            this.tijdLbl.Text = "HH:mm:ss";
            // 
            // sluitLbl
            // 
            this.sluitLbl.BackColor = System.Drawing.Color.Transparent;
            this.sluitLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sluitLbl.Image = ((System.Drawing.Image)(resources.GetObject("sluitLbl.Image")));
            this.sluitLbl.Location = new System.Drawing.Point(16, 9);
            this.sluitLbl.Margin = new System.Windows.Forms.Padding(0);
            this.sluitLbl.Name = "sluitLbl";
            this.sluitLbl.Size = new System.Drawing.Size(14, 14);
            this.sluitLbl.TabIndex = 9;
            this.sluitLbl.MouseHover += new System.EventHandler(this.sluitLbl_MouseHover);
            // 
            // minLbl
            // 
            this.minLbl.BackColor = System.Drawing.Color.Transparent;
            this.minLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minLbl.Image = ((System.Drawing.Image)(resources.GetObject("minLbl.Image")));
            this.minLbl.Location = new System.Drawing.Point(37, 9);
            this.minLbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.minLbl.Name = "minLbl";
            this.minLbl.Size = new System.Drawing.Size(14, 14);
            this.minLbl.TabIndex = 10;
            this.minLbl.MouseHover += new System.EventHandler(this.minLbl_MouseHover);
            // 
            // plusLbl
            // 
            this.plusLbl.BackColor = System.Drawing.Color.Transparent;
            this.plusLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusLbl.Image = ((System.Drawing.Image)(resources.GetObject("plusLbl.Image")));
            this.plusLbl.Location = new System.Drawing.Point(58, 9);
            this.plusLbl.Margin = new System.Windows.Forms.Padding(0);
            this.plusLbl.Name = "plusLbl";
            this.plusLbl.Size = new System.Drawing.Size(14, 14);
            this.plusLbl.TabIndex = 11;
            this.plusLbl.MouseHover += new System.EventHandler(this.plusLbl_MouseHover);
            // 
            // minLbl2
            // 
            this.minLbl2.BackColor = System.Drawing.Color.Transparent;
            this.minLbl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minLbl2.Image = ((System.Drawing.Image)(resources.GetObject("minLbl2.Image")));
            this.minLbl2.Location = new System.Drawing.Point(37, 9);
            this.minLbl2.Name = "minLbl2";
            this.minLbl2.Size = new System.Drawing.Size(14, 14);
            this.minLbl2.TabIndex = 12;
            this.minLbl2.Visible = false;
            this.minLbl2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minLbl2_MouseClick);
            this.minLbl2.MouseLeave += new System.EventHandler(this.minLbl2_MouseLeave);
            // 
            // plusLbl2
            // 
            this.plusLbl2.BackColor = System.Drawing.Color.Transparent;
            this.plusLbl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusLbl2.Image = ((System.Drawing.Image)(resources.GetObject("plusLbl2.Image")));
            this.plusLbl2.Location = new System.Drawing.Point(58, 9);
            this.plusLbl2.Margin = new System.Windows.Forms.Padding(0);
            this.plusLbl2.Name = "plusLbl2";
            this.plusLbl2.Size = new System.Drawing.Size(14, 14);
            this.plusLbl2.TabIndex = 13;
            this.plusLbl2.Visible = false;
            this.plusLbl2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.plusLbl2_MouseClick);
            this.plusLbl2.MouseLeave += new System.EventHandler(this.plusLbl2_MouseLeave);
            // 
            // sluitLbl2
            // 
            this.sluitLbl2.BackColor = System.Drawing.Color.Transparent;
            this.sluitLbl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sluitLbl2.Image = ((System.Drawing.Image)(resources.GetObject("sluitLbl2.Image")));
            this.sluitLbl2.Location = new System.Drawing.Point(15, 9);
            this.sluitLbl2.Margin = new System.Windows.Forms.Padding(0);
            this.sluitLbl2.Name = "sluitLbl2";
            this.sluitLbl2.Size = new System.Drawing.Size(14, 14);
            this.sluitLbl2.TabIndex = 14;
            this.sluitLbl2.Visible = false;
            this.sluitLbl2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sluitLbl2_MouseClick);
            this.sluitLbl2.MouseLeave += new System.EventHandler(this.sluitLbl2_MouseLeave);
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
            this.changePictureLabel.ForeColor = System.Drawing.Color.Black;
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
            this.signOutLabel.ForeColor = System.Drawing.Color.Black;
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
            this.exitLabel.ForeColor = System.Drawing.Color.Black;
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 559);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.signOutLabel);
            this.Controls.Add(this.changePictureLabel);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.sluitLbl2);
            this.Controls.Add(this.plusLbl2);
            this.Controls.Add(this.minLbl2);
            this.Controls.Add(this.plusLbl);
            this.Controls.Add(this.minLbl);
            this.Controls.Add(this.sluitLbl);
            this.Controls.Add(this.tijdLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.startLbl);
            this.Controls.Add(this.gamesButton);
            this.Controls.Add(this.resultatenBtn);
            this.Controls.Add(this.oefenButton);
            this.Controls.Add(this.examenBtn);
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

        private System.Windows.Forms.Button examenBtn;
        private System.Windows.Forms.Button oefenButton;
        private System.Windows.Forms.Button gamesButton;
        private System.Windows.Forms.Button resultatenBtn;
        private System.Windows.Forms.Label startLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Timer timerTijd;
        private System.Windows.Forms.Label tijdLbl;
        private System.Windows.Forms.Label sluitLbl;
        private System.Windows.Forms.Label minLbl;
        private System.Windows.Forms.Label plusLbl;
        private System.Windows.Forms.Label minLbl2;
        private System.Windows.Forms.Label plusLbl2;
        private System.Windows.Forms.Label sluitLbl2;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label changePictureLabel;
        private System.Windows.Forms.Label signOutLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Timer timerCredits;
    }
}