namespace BasicSec04
{
    partial class EncryptFile
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptFile));
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.selectKeyLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.browseInputButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.browseOutputButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.folderpathTextBox = new System.Windows.Forms.TextBox();
            this.encryptFileTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.enterPassLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.percentLabel = new System.Windows.Forms.Label();
            this.waitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usersComboBox
            // 
            this.usersComboBox.BackColor = System.Drawing.Color.White;
            this.usersComboBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.usersComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(330, 246);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(155, 28);
            this.usersComboBox.TabIndex = 5;
            this.usersComboBox.Visible = false;
            // 
            // selectKeyLabel
            // 
            this.selectKeyLabel.AutoSize = true;
            this.selectKeyLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectKeyLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectKeyLabel.ForeColor = System.Drawing.Color.White;
            this.selectKeyLabel.Location = new System.Drawing.Point(66, 246);
            this.selectKeyLabel.Name = "selectKeyLabel";
            this.selectKeyLabel.Size = new System.Drawing.Size(124, 20);
            this.selectKeyLabel.TabIndex = 6;
            this.selectKeyLabel.Text = "Select Public Key:";
            this.selectKeyLabel.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DimGray;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatAppearance.BorderSize = 2;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(676, 479);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 32);
            this.exitButton.TabIndex = 29;
            this.exitButton.Text = "Sluiten";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.BackColor = System.Drawing.Color.DimGray;
            this.encryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encryptButton.FlatAppearance.BorderSize = 2;
            this.encryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.encryptButton.ForeColor = System.Drawing.Color.White;
            this.encryptButton.Location = new System.Drawing.Point(508, 243);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(90, 32);
            this.encryptButton.TabIndex = 30;
            this.encryptButton.Text = "Encrypt";
            this.encryptFileTooltip.SetToolTip(this.encryptButton, "Encrypt file");
            this.encryptButton.UseVisualStyleBackColor = false;
            this.encryptButton.Visible = false;
            this.encryptButton.Click += new System.EventHandler(this.encryptFileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Select the file you wish to encrypt";
            // 
            // browseInputButton
            // 
            this.browseInputButton.BackColor = System.Drawing.Color.DimGray;
            this.browseInputButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseInputButton.FlatAppearance.BorderSize = 2;
            this.browseInputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseInputButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.browseInputButton.ForeColor = System.Drawing.Color.White;
            this.browseInputButton.Location = new System.Drawing.Point(508, 66);
            this.browseInputButton.Name = "browseInputButton";
            this.browseInputButton.Size = new System.Drawing.Size(90, 32);
            this.browseInputButton.TabIndex = 32;
            this.browseInputButton.Text = "Browse";
            this.browseInputButton.UseVisualStyleBackColor = false;
            this.browseInputButton.Click += new System.EventHandler(this.browseInputButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.filePathTextBox.Location = new System.Drawing.Point(181, 69);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(304, 27);
            this.filePathTextBox.TabIndex = 33;
            // 
            // browseOutputButton
            // 
            this.browseOutputButton.BackColor = System.Drawing.Color.DimGray;
            this.browseOutputButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseOutputButton.FlatAppearance.BorderSize = 2;
            this.browseOutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseOutputButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.browseOutputButton.ForeColor = System.Drawing.Color.White;
            this.browseOutputButton.Location = new System.Drawing.Point(508, 124);
            this.browseOutputButton.Name = "browseOutputButton";
            this.browseOutputButton.Size = new System.Drawing.Size(90, 32);
            this.browseOutputButton.TabIndex = 34;
            this.browseOutputButton.Text = "Browse";
            this.browseOutputButton.UseVisualStyleBackColor = false;
            this.browseOutputButton.Visible = false;
            this.browseOutputButton.Click += new System.EventHandler(this.browseOutputButton_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.BackColor = System.Drawing.Color.Transparent;
            this.inputLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.ForeColor = System.Drawing.Color.White;
            this.inputLabel.Location = new System.Drawing.Point(66, 70);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(71, 20);
            this.inputLabel.TabIndex = 35;
            this.inputLabel.Text = "Input file:";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(66, 130);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(102, 20);
            this.outputLabel.TabIndex = 36;
            this.outputLabel.Text = "Output folder:";
            this.outputLabel.Visible = false;
            // 
            // folderpathTextBox
            // 
            this.folderpathTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.folderpathTextBox.Location = new System.Drawing.Point(181, 127);
            this.folderpathTextBox.Name = "folderpathTextBox";
            this.folderpathTextBox.ReadOnly = true;
            this.folderpathTextBox.Size = new System.Drawing.Size(304, 27);
            this.folderpathTextBox.TabIndex = 37;
            this.folderpathTextBox.Visible = false;
            // 
            // enterPassLabel
            // 
            this.enterPassLabel.AutoSize = true;
            this.enterPassLabel.BackColor = System.Drawing.Color.Transparent;
            this.enterPassLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPassLabel.ForeColor = System.Drawing.Color.White;
            this.enterPassLabel.Location = new System.Drawing.Point(66, 190);
            this.enterPassLabel.Name = "enterPassLabel";
            this.enterPassLabel.Size = new System.Drawing.Size(100, 20);
            this.enterPassLabel.TabIndex = 38;
            this.enterPassLabel.Text = "Set password:";
            this.enterPassLabel.Visible = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.passwordTextBox.Location = new System.Drawing.Point(181, 187);
            this.passwordTextBox.MaxLength = 20;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(304, 27);
            this.passwordTextBox.TabIndex = 39;
            this.passwordTextBox.Visible = false;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoLabel.Image = ((System.Drawing.Image)(resources.GetObject("infoLabel.Image")));
            this.infoLabel.Location = new System.Drawing.Point(515, 187);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(25, 25);
            this.infoLabel.TabIndex = 40;
            this.infoLabel.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(70, 343);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(491, 23);
            this.progressBar.TabIndex = 41;
            this.progressBar.Visible = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.BackColor = System.Drawing.Color.Transparent;
            this.percentLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLabel.ForeColor = System.Drawing.Color.White;
            this.percentLabel.Location = new System.Drawing.Point(567, 344);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(31, 20);
            this.percentLabel.TabIndex = 42;
            this.percentLabel.Text = "0%";
            this.percentLabel.Visible = false;
            // 
            // waitLabel
            // 
            this.waitLabel.AutoSize = true;
            this.waitLabel.BackColor = System.Drawing.Color.Transparent;
            this.waitLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitLabel.ForeColor = System.Drawing.Color.White;
            this.waitLabel.Location = new System.Drawing.Point(67, 314);
            this.waitLabel.Name = "waitLabel";
            this.waitLabel.Size = new System.Drawing.Size(284, 17);
            this.waitLabel.TabIndex = 43;
            this.waitLabel.Text = "Please, wait ... while we are encrypting your file ";
            this.waitLabel.Visible = false;
            // 
            // EncryptFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 559);
            this.Controls.Add(this.waitLabel);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.enterPassLabel);
            this.Controls.Add(this.folderpathTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.browseOutputButton);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.browseInputButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.selectKeyLabel);
            this.Controls.Add(this.usersComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EncryptFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Encrypt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ComboBox usersComboBox;
        private System.Windows.Forms.Label selectKeyLabel;
        private System.Windows.Forms.Button exitButton;

        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button browseInputButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button browseOutputButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox folderpathTextBox;
        private System.Windows.Forms.ToolTip encryptFileTooltip;
        private System.Windows.Forms.Label enterPassLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Label waitLabel;


    }
}