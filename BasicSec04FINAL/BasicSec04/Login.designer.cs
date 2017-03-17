namespace BasicSec04
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
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.tijdLabel = new System.Windows.Forms.Label();
            this.continueLabel = new System.Windows.Forms.Label();
            this.errorNoneExistant = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorWrongPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFieldEmpty = new System.Windows.Forms.ErrorProvider(this.components);
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.pwdWatermarkLabel = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.requestAccountLabel = new System.Windows.Forms.LinkLabel();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.tijdTimer = new System.Windows.Forms.Timer(this.components);
            this.recoveryLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoneExistant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWrongPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFieldEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.White;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.Location = new System.Drawing.Point(398, 211);
            this.emailTextBox.MaxLength = 45;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(194, 29);
            this.emailTextBox.TabIndex = 0;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
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
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(397, 190);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Locked";
            // 
            // exitLabel
            // 
            this.exitLabel.BackColor = System.Drawing.Color.Transparent;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Image = ((System.Drawing.Image)(resources.GetObject("exitLabel.Image")));
            this.exitLabel.Location = new System.Drawing.Point(717, 494);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(25, 25);
            this.exitLabel.TabIndex = 4;
            this.exitLabel.Click += new System.EventHandler(this.exitLbl_Click);
            // 
            // tijdLabel
            // 
            this.tijdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tijdLabel.AutoSize = true;
            this.tijdLabel.BackColor = System.Drawing.Color.Transparent;
            this.tijdLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tijdLabel.ForeColor = System.Drawing.Color.White;
            this.tijdLabel.Location = new System.Drawing.Point(657, 42);
            this.tijdLabel.Name = "tijdLabel";
            this.tijdLabel.Size = new System.Drawing.Size(107, 30);
            this.tijdLabel.TabIndex = 9;
            this.tijdLabel.Text = "HH:mm:ss";
            // 
            // continueLabel
            // 
            this.continueLabel.BackColor = System.Drawing.Color.White;
            this.continueLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continueLabel.Image = ((System.Drawing.Image)(resources.GetObject("continueLabel.Image")));
            this.continueLabel.Location = new System.Drawing.Point(570, 244);
            this.continueLabel.Name = "continueLabel";
            this.continueLabel.Size = new System.Drawing.Size(20, 20);
            this.continueLabel.TabIndex = 10;
            this.continueLabel.Visible = false;
            this.continueLabel.Click += new System.EventHandler(this.cntnLbl_Click);
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
            this.pwdTextBox.BackColor = System.Drawing.Color.White;
            this.pwdTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pwdTextBox.ForeColor = System.Drawing.Color.Black;
            this.pwdTextBox.Location = new System.Drawing.Point(398, 242);
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
            this.pwdWatermarkLabel.BackColor = System.Drawing.SystemColors.Window;
            this.pwdWatermarkLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwdWatermarkLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.pwdWatermarkLabel.Location = new System.Drawing.Point(401, 248);
            this.pwdWatermarkLabel.Name = "pwdWatermarkLabel";
            this.pwdWatermarkLabel.Size = new System.Drawing.Size(66, 13);
            this.pwdWatermarkLabel.TabIndex = 12;
            this.pwdWatermarkLabel.Text = "Passwoord";
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
            this.profilePictureBox.Location = new System.Drawing.Point(246, 167);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(140, 125);
            this.profilePictureBox.TabIndex = 14;
            this.profilePictureBox.TabStop = false;
            // 
            // requestAccountLabel
            // 
            this.requestAccountLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.requestAccountLabel.AutoSize = true;
            this.requestAccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.requestAccountLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.requestAccountLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestAccountLabel.ForeColor = System.Drawing.Color.White;
            this.requestAccountLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.requestAccountLabel.LinkColor = System.Drawing.Color.White;
            this.requestAccountLabel.Location = new System.Drawing.Point(488, 274);
            this.requestAccountLabel.Name = "requestAccountLabel";
            this.requestAccountLabel.Size = new System.Drawing.Size(107, 13);
            this.requestAccountLabel.TabIndex = 3;
            this.requestAccountLabel.TabStop = true;
            this.requestAccountLabel.Text = "Account Aanvragen";
            this.requestAccountLabel.Visible = false;
            this.requestAccountLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.requestAccountLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.requestAccountLabel_LinkClicked);
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadingLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.loadingLabel.ForeColor = System.Drawing.Color.White;
            this.loadingLabel.Location = new System.Drawing.Point(607, 500);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(85, 19);
            this.loadingLabel.TabIndex = 22;
            this.loadingLabel.Text = "Please wait...";
            this.loadingLabel.Visible = false;
            // 
            // tijdTimer
            // 
            this.tijdTimer.Tick += new System.EventHandler(this.tijdTimer_Tick);
            // 
            // recoveryLabel
            // 
            this.recoveryLabel.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.recoveryLabel.BackColor = System.Drawing.Color.Transparent;
            this.recoveryLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recoveryLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoveryLabel.ForeColor = System.Drawing.Color.White;
            this.recoveryLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.recoveryLabel.LinkColor = System.Drawing.Color.White;
            this.recoveryLabel.Location = new System.Drawing.Point(397, 274);
            this.recoveryLabel.Name = "recoveryLabel";
            this.recoveryLabel.Size = new System.Drawing.Size(75, 28);
            this.recoveryLabel.TabIndex = 23;
            this.recoveryLabel.TabStop = true;
            this.recoveryLabel.Text = "Passwoord Vergeten ?";
            this.recoveryLabel.Visible = false;
            this.recoveryLabel.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 559);
            this.Controls.Add(this.recoveryLabel);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.requestAccountLabel);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.pwdWatermarkLabel);
            this.Controls.Add(this.continueLabel);
            this.Controls.Add(this.tijdLabel);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.pwdTextBox);
            this.Controls.Add(this.emailTextBox);
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

        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label tijdLabel;
        private System.Windows.Forms.Label continueLabel;
        private System.Windows.Forms.ErrorProvider errorNoneExistant;
        private System.Windows.Forms.ErrorProvider errorWrongPass;
        private System.Windows.Forms.ErrorProvider errorFieldEmpty;
        private System.Windows.Forms.TextBox pwdTextBox;
        private System.Windows.Forms.Label pwdWatermarkLabel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.LinkLabel requestAccountLabel;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.Timer tijdTimer;
        private System.Windows.Forms.LinkLabel recoveryLabel;
    }
}