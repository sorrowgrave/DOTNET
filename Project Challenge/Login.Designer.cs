namespace DrivingPXL
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usernTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.tijdLbl = new System.Windows.Forms.Label();
            this.tijdTimer = new System.Windows.Forms.Timer(this.components);
            this.cntnLbl = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.LinkLabel();
            this.errorNoneExistant = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorWrongPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFieldEmpty = new System.Windows.Forms.ErrorProvider(this.components);
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.pwdWatermarkLabel = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.passRecoveryLabel = new System.Windows.Forms.LinkLabel();
            this.sendingLabel = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoneExistant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWrongPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFieldEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernTextBox
            // 
            this.usernTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.usernTextBox.Location = new System.Drawing.Point(398, 214);
            this.usernTextBox.MaxLength = 45;
            this.usernTextBox.Name = "usernTextBox";
            this.usernTextBox.Size = new System.Drawing.Size(194, 25);
            this.usernTextBox.TabIndex = 0;
            this.usernTextBox.TextChanged += new System.EventHandler(this.usernTextBox_TextChanged);
            this.usernTextBox.Leave += new System.EventHandler(this.usernTextBox_Leave);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(392, 158);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(62, 32);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(397, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Locked";
            // 
            // exitLabel
            // 
            this.exitLabel.BackColor = System.Drawing.Color.Transparent;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Image = ((System.Drawing.Image)(resources.GetObject("exitLabel.Image")));
            this.exitLabel.Location = new System.Drawing.Point(701, 492);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(22, 25);
            this.exitLabel.TabIndex = 4;
            this.exitLabel.Click += new System.EventHandler(this.exitLbl_Click);
            // 
            // tijdLbl
            // 
            this.tijdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tijdLbl.AutoSize = true;
            this.tijdLbl.BackColor = System.Drawing.Color.Transparent;
            this.tijdLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tijdLbl.ForeColor = System.Drawing.Color.White;
            this.tijdLbl.Location = new System.Drawing.Point(657, 42);
            this.tijdLbl.Name = "tijdLbl";
            this.tijdLbl.Size = new System.Drawing.Size(107, 30);
            this.tijdLbl.TabIndex = 9;
            this.tijdLbl.Text = "HH:mm:ss";
            // 
            // tijdTimer
            // 
            this.tijdTimer.Tick += new System.EventHandler(this.tijdTimer_Tick);
            // 
            // cntnLbl
            // 
            this.cntnLbl.BackColor = System.Drawing.Color.Transparent;
            this.cntnLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cntnLbl.Image = ((System.Drawing.Image)(resources.GetObject("cntnLbl.Image")));
            this.cntnLbl.Location = new System.Drawing.Point(570, 248);
            this.cntnLbl.Name = "cntnLbl";
            this.cntnLbl.Size = new System.Drawing.Size(20, 20);
            this.cntnLbl.TabIndex = 10;
            this.cntnLbl.Visible = false;
            this.cntnLbl.Click += new System.EventHandler(this.cntnLbl_Click);
            // 
            // registerLabel
            // 
            this.registerLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.registerLabel.AutoSize = true;
            this.registerLabel.BackColor = System.Drawing.Color.Transparent;
            this.registerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.registerLabel.LinkColor = System.Drawing.Color.White;
            this.registerLabel.Location = new System.Drawing.Point(396, 243);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(49, 13);
            this.registerLabel.TabIndex = 2;
            this.registerLabel.TabStop = true;
            this.registerLabel.Text = "Register";
            this.registerLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.registerLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLabel_LinkClicked);
            // 
            // errorNoneExistant
            // 
            this.errorNoneExistant.ContainerControl = this;
            this.errorNoneExistant.Icon = ((System.Drawing.Icon)(resources.GetObject("errorNoneExistant.Icon")));
            // 
            // errorWrongPass
            // 
            this.errorWrongPass.ContainerControl = this;
            this.errorWrongPass.Icon = ((System.Drawing.Icon)(resources.GetObject("errorWrongPass.Icon")));
            // 
            // errorFieldEmpty
            // 
            this.errorFieldEmpty.ContainerControl = this;
            this.errorFieldEmpty.Icon = ((System.Drawing.Icon)(resources.GetObject("errorFieldEmpty.Icon")));
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pwdTextBox.Location = new System.Drawing.Point(398, 245);
            this.pwdTextBox.MaxLength = 21;
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.Size = new System.Drawing.Size(194, 25);
            this.pwdTextBox.TabIndex = 1;
            this.pwdTextBox.UseSystemPasswordChar = true;
            this.pwdTextBox.Visible = false;
            this.pwdTextBox.Enter += new System.EventHandler(this.pwdTextBox_Enter);
            this.pwdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwdTextBox_KeyDown);
            this.pwdTextBox.Leave += new System.EventHandler(this.pwdTextBox_Leave);
            // 
            // pwdWatermarkLabel
            // 
            this.pwdWatermarkLabel.BackColor = System.Drawing.Color.White;
            this.pwdWatermarkLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwdWatermarkLabel.ForeColor = System.Drawing.Color.Gray;
            this.pwdWatermarkLabel.Location = new System.Drawing.Point(401, 251);
            this.pwdWatermarkLabel.Name = "pwdWatermarkLabel";
            this.pwdWatermarkLabel.Size = new System.Drawing.Size(55, 13);
            this.pwdWatermarkLabel.TabIndex = 12;
            this.pwdWatermarkLabel.Text = "Password";
            this.pwdWatermarkLabel.Visible = false;
            this.pwdWatermarkLabel.Click += new System.EventHandler(this.pwdWatermarkLabel_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.profilePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profilePictureBox.BackgroundImage")));
            this.profilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePictureBox.Enabled = false;
            this.profilePictureBox.ErrorImage = null;
            this.profilePictureBox.Location = new System.Drawing.Point(261, 162);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(125, 125);
            this.profilePictureBox.TabIndex = 14;
            this.profilePictureBox.TabStop = false;
            // 
            // passRecoveryLabel
            // 
            this.passRecoveryLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.passRecoveryLabel.AutoSize = true;
            this.passRecoveryLabel.BackColor = System.Drawing.Color.Transparent;
            this.passRecoveryLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passRecoveryLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passRecoveryLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.passRecoveryLabel.LinkColor = System.Drawing.Color.White;
            this.passRecoveryLabel.Location = new System.Drawing.Point(470, 274);
            this.passRecoveryLabel.Name = "passRecoveryLabel";
            this.passRecoveryLabel.Size = new System.Drawing.Size(126, 13);
            this.passRecoveryLabel.TabIndex = 3;
            this.passRecoveryLabel.TabStop = true;
            this.passRecoveryLabel.Text = "Forgot your password?";
            this.passRecoveryLabel.Visible = false;
            this.passRecoveryLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.passRecoveryLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.passRecoveryLabel_LinkClicked);
            // 
            // sendingLabel
            // 
            this.sendingLabel.AutoSize = true;
            this.sendingLabel.BackColor = System.Drawing.Color.Transparent;
            this.sendingLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sendingLabel.ForeColor = System.Drawing.Color.White;
            this.sendingLabel.Location = new System.Drawing.Point(591, 494);
            this.sendingLabel.Name = "sendingLabel";
            this.sendingLabel.Size = new System.Drawing.Size(85, 19);
            this.sendingLabel.TabIndex = 22;
            this.sendingLabel.Text = "Please wait...";
            this.sendingLabel.Visible = false;
            // 
            // creditsLabel
            // 
            this.creditsLabel.BackColor = System.Drawing.Color.Transparent;
            this.creditsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel.ForeColor = System.Drawing.Color.White;
            this.creditsLabel.Location = new System.Drawing.Point(88, 496);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(214, 21);
            this.creditsLabel.TabIndex = 23;
            this.creditsLabel.Text = "Credits to: Niels Carmans,  Lars Hoho,  Olivier Quaethoven,  Kenny Vanrusselt  @ " +
    "PXL Hasselt  2013-2014";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 559);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.sendingLabel);
            this.Controls.Add(this.passRecoveryLabel);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.pwdWatermarkLabel);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.cntnLbl);
            this.Controls.Add(this.tijdLbl);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.pwdTextBox);
            this.Controls.Add(this.usernTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(821, 559);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorNoneExistant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWrongPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFieldEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label tijdLbl;
        private System.Windows.Forms.Timer tijdTimer;
        private System.Windows.Forms.Label cntnLbl;
        private System.Windows.Forms.LinkLabel registerLabel;
        private System.Windows.Forms.ErrorProvider errorNoneExistant;
        private System.Windows.Forms.ErrorProvider errorWrongPass;
        private System.Windows.Forms.ErrorProvider errorFieldEmpty;
        private System.Windows.Forms.TextBox pwdTextBox;
        private System.Windows.Forms.Label pwdWatermarkLabel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.LinkLabel passRecoveryLabel;
        private System.Windows.Forms.Label sendingLabel;
        private System.Windows.Forms.Label creditsLabel;
    }
}