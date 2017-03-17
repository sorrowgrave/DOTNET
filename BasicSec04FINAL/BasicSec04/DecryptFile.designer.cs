namespace BasicSec04
{
    partial class DecryptFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecryptFile));
            this.exitButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.openInputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.browseInputButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.browseAESKeyButton = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.selectKeyLabel = new System.Windows.Forms.Label();
            this.aesPathTextBox = new System.Windows.Forms.TextBox();
            this.openAESFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.decryptTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.selectPubKeyLabel = new System.Windows.Forms.Label();
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.hashGroupBox = new System.Windows.Forms.GroupBox();
            this.hashCheckLabel = new System.Windows.Forms.Label();
            this.hashStatusLabel = new System.Windows.Forms.Label();
            this.hashPathTextBox = new System.Windows.Forms.TextBox();
            this.selectHashLabel = new System.Windows.Forms.Label();
            this.browseHashButton = new System.Windows.Forms.Button();
            this.openHashFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderpathTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.browseOutputButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.waitLabel = new System.Windows.Forms.Label();
            this.percentLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.hashGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            // decryptButton
            // 
            this.decryptButton.BackColor = System.Drawing.Color.DimGray;
            this.decryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decryptButton.FlatAppearance.BorderSize = 2;
            this.decryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.decryptButton.ForeColor = System.Drawing.Color.White;
            this.decryptButton.Location = new System.Drawing.Point(477, 96);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(90, 32);
            this.decryptButton.TabIndex = 31;
            this.decryptButton.Text = "Decrypt";
            this.decryptTooltip.SetToolTip(this.decryptButton, "Decrypt the file");
            this.decryptButton.UseVisualStyleBackColor = false;
            this.decryptButton.Visible = false;
            this.decryptButton.Click += new System.EventHandler(this.decryptFileButton_Click);
            // 
            // openInputFileDialog
            // 
            this.openInputFileDialog.FileName = "Select input file";
            // 
            // browseInputButton
            // 
            this.browseInputButton.BackColor = System.Drawing.Color.DimGray;
            this.browseInputButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseInputButton.FlatAppearance.BorderSize = 2;
            this.browseInputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseInputButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.browseInputButton.ForeColor = System.Drawing.Color.White;
            this.browseInputButton.Location = new System.Drawing.Point(539, 30);
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
            this.filePathTextBox.Location = new System.Drawing.Point(212, 33);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(304, 27);
            this.filePathTextBox.TabIndex = 33;
            // 
            // browseAESKeyButton
            // 
            this.browseAESKeyButton.BackColor = System.Drawing.Color.DimGray;
            this.browseAESKeyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseAESKeyButton.FlatAppearance.BorderSize = 2;
            this.browseAESKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseAESKeyButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.browseAESKeyButton.ForeColor = System.Drawing.Color.White;
            this.browseAESKeyButton.Location = new System.Drawing.Point(539, 146);
            this.browseAESKeyButton.Name = "browseAESKeyButton";
            this.browseAESKeyButton.Size = new System.Drawing.Size(90, 32);
            this.browseAESKeyButton.TabIndex = 34;
            this.browseAESKeyButton.Text = "Browse";
            this.browseAESKeyButton.UseVisualStyleBackColor = false;
            this.browseAESKeyButton.Visible = false;
            this.browseAESKeyButton.Click += new System.EventHandler(this.browseAESKeyButton_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.BackColor = System.Drawing.Color.Transparent;
            this.inputLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.ForeColor = System.Drawing.Color.White;
            this.inputLabel.Location = new System.Drawing.Point(79, 34);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(71, 20);
            this.inputLabel.TabIndex = 35;
            this.inputLabel.Text = "Input file:";
            // 
            // selectKeyLabel
            // 
            this.selectKeyLabel.AutoSize = true;
            this.selectKeyLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectKeyLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectKeyLabel.ForeColor = System.Drawing.Color.White;
            this.selectKeyLabel.Location = new System.Drawing.Point(79, 152);
            this.selectKeyLabel.Name = "selectKeyLabel";
            this.selectKeyLabel.Size = new System.Drawing.Size(110, 20);
            this.selectKeyLabel.TabIndex = 36;
            this.selectKeyLabel.Text = "Select AES Key:";
            this.selectKeyLabel.Visible = false;
            // 
            // aesPathTextBox
            // 
            this.aesPathTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.aesPathTextBox.Location = new System.Drawing.Point(212, 149);
            this.aesPathTextBox.Name = "aesPathTextBox";
            this.aesPathTextBox.ReadOnly = true;
            this.aesPathTextBox.Size = new System.Drawing.Size(304, 27);
            this.aesPathTextBox.TabIndex = 37;
            this.aesPathTextBox.Visible = false;
            // 
            // openAESFileDialog
            // 
            this.openAESFileDialog.FileName = "Select AES Key";
            // 
            // selectPubKeyLabel
            // 
            this.selectPubKeyLabel.AutoSize = true;
            this.selectPubKeyLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectPubKeyLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPubKeyLabel.ForeColor = System.Drawing.Color.White;
            this.selectPubKeyLabel.Location = new System.Drawing.Point(17, 101);
            this.selectPubKeyLabel.Name = "selectPubKeyLabel";
            this.selectPubKeyLabel.Size = new System.Drawing.Size(124, 20);
            this.selectPubKeyLabel.TabIndex = 39;
            this.selectPubKeyLabel.Text = "Select Public Key:";
            this.selectPubKeyLabel.Visible = false;
            // 
            // usersComboBox
            // 
            this.usersComboBox.BackColor = System.Drawing.Color.White;
            this.usersComboBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.usersComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(150, 98);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(304, 28);
            this.usersComboBox.TabIndex = 38;
            this.usersComboBox.Visible = false;
            // 
            // hashGroupBox
            // 
            this.hashGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.hashGroupBox.Controls.Add(this.waitLabel);
            this.hashGroupBox.Controls.Add(this.hashCheckLabel);
            this.hashGroupBox.Controls.Add(this.percentLabel);
            this.hashGroupBox.Controls.Add(this.hashStatusLabel);
            this.hashGroupBox.Controls.Add(this.progressBar);
            this.hashGroupBox.Controls.Add(this.hashPathTextBox);
            this.hashGroupBox.Controls.Add(this.selectHashLabel);
            this.hashGroupBox.Controls.Add(this.browseHashButton);
            this.hashGroupBox.Controls.Add(this.selectPubKeyLabel);
            this.hashGroupBox.Controls.Add(this.usersComboBox);
            this.hashGroupBox.Controls.Add(this.decryptButton);
            this.hashGroupBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashGroupBox.ForeColor = System.Drawing.Color.White;
            this.hashGroupBox.Location = new System.Drawing.Point(62, 201);
            this.hashGroupBox.Name = "hashGroupBox";
            this.hashGroupBox.Size = new System.Drawing.Size(689, 213);
            this.hashGroupBox.TabIndex = 41;
            this.hashGroupBox.TabStop = false;
            this.hashGroupBox.Text = "Hashcheck";
            this.hashGroupBox.Visible = false;
            // 
            // hashCheckLabel
            // 
            this.hashCheckLabel.BackColor = System.Drawing.Color.Transparent;
            this.hashCheckLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.hashCheckLabel.Location = new System.Drawing.Point(146, 156);
            this.hashCheckLabel.Name = "hashCheckLabel";
            this.hashCheckLabel.Size = new System.Drawing.Size(515, 54);
            this.hashCheckLabel.TabIndex = 42;
            this.hashCheckLabel.Visible = false;
            // 
            // hashStatusLabel
            // 
            this.hashStatusLabel.AutoSize = true;
            this.hashStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.hashStatusLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashStatusLabel.ForeColor = System.Drawing.Color.White;
            this.hashStatusLabel.Location = new System.Drawing.Point(17, 159);
            this.hashStatusLabel.Name = "hashStatusLabel";
            this.hashStatusLabel.Size = new System.Drawing.Size(89, 20);
            this.hashStatusLabel.TabIndex = 42;
            this.hashStatusLabel.Text = "Hash Status:";
            this.hashStatusLabel.Visible = false;
            // 
            // hashPathTextBox
            // 
            this.hashPathTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.hashPathTextBox.Location = new System.Drawing.Point(150, 40);
            this.hashPathTextBox.Name = "hashPathTextBox";
            this.hashPathTextBox.ReadOnly = true;
            this.hashPathTextBox.Size = new System.Drawing.Size(304, 27);
            this.hashPathTextBox.TabIndex = 43;
            this.hashPathTextBox.Visible = false;
            // 
            // selectHashLabel
            // 
            this.selectHashLabel.AutoSize = true;
            this.selectHashLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectHashLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectHashLabel.ForeColor = System.Drawing.Color.White;
            this.selectHashLabel.Location = new System.Drawing.Point(17, 43);
            this.selectHashLabel.Name = "selectHashLabel";
            this.selectHashLabel.Size = new System.Drawing.Size(116, 20);
            this.selectHashLabel.TabIndex = 42;
            this.selectHashLabel.Text = "Select Hash File:";
            this.selectHashLabel.Visible = false;
            // 
            // browseHashButton
            // 
            this.browseHashButton.BackColor = System.Drawing.Color.DimGray;
            this.browseHashButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseHashButton.FlatAppearance.BorderSize = 2;
            this.browseHashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseHashButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.browseHashButton.ForeColor = System.Drawing.Color.White;
            this.browseHashButton.Location = new System.Drawing.Point(477, 38);
            this.browseHashButton.Name = "browseHashButton";
            this.browseHashButton.Size = new System.Drawing.Size(90, 32);
            this.browseHashButton.TabIndex = 41;
            this.browseHashButton.Text = "Browse";
            this.browseHashButton.UseVisualStyleBackColor = false;
            this.browseHashButton.Visible = false;
            this.browseHashButton.Click += new System.EventHandler(this.browseHashButton_Click);
            // 
            // openHashFileDialog
            // 
            this.openHashFileDialog.FileName = "Select the hash file";
            // 
            // folderpathTextBox
            // 
            this.folderpathTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.folderpathTextBox.Location = new System.Drawing.Point(212, 92);
            this.folderpathTextBox.Name = "folderpathTextBox";
            this.folderpathTextBox.ReadOnly = true;
            this.folderpathTextBox.Size = new System.Drawing.Size(304, 27);
            this.folderpathTextBox.TabIndex = 46;
            this.folderpathTextBox.Visible = false;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(79, 94);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(102, 20);
            this.outputLabel.TabIndex = 45;
            this.outputLabel.Text = "Output folder:";
            this.outputLabel.Visible = false;
            // 
            // browseOutputButton
            // 
            this.browseOutputButton.BackColor = System.Drawing.Color.DimGray;
            this.browseOutputButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseOutputButton.FlatAppearance.BorderSize = 2;
            this.browseOutputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseOutputButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.browseOutputButton.ForeColor = System.Drawing.Color.White;
            this.browseOutputButton.Location = new System.Drawing.Point(539, 89);
            this.browseOutputButton.Name = "browseOutputButton";
            this.browseOutputButton.Size = new System.Drawing.Size(90, 32);
            this.browseOutputButton.TabIndex = 44;
            this.browseOutputButton.Text = "Browse";
            this.browseOutputButton.UseVisualStyleBackColor = false;
            this.browseOutputButton.Visible = false;
            this.browseOutputButton.Click += new System.EventHandler(this.browseOutputButton_Click);
            // 
            // waitLabel
            // 
            this.waitLabel.AutoSize = true;
            this.waitLabel.BackColor = System.Drawing.Color.Transparent;
            this.waitLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitLabel.ForeColor = System.Drawing.Color.White;
            this.waitLabel.Location = new System.Drawing.Point(18, 140);
            this.waitLabel.Name = "waitLabel";
            this.waitLabel.Size = new System.Drawing.Size(284, 17);
            this.waitLabel.TabIndex = 49;
            this.waitLabel.Text = "Please, wait ... while we are encrypting your file ";
            this.waitLabel.Visible = false;
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.BackColor = System.Drawing.Color.Transparent;
            this.percentLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentLabel.ForeColor = System.Drawing.Color.White;
            this.percentLabel.Location = new System.Drawing.Point(518, 170);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(31, 20);
            this.percentLabel.TabIndex = 48;
            this.percentLabel.Text = "0%";
            this.percentLabel.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(21, 169);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(491, 23);
            this.progressBar.TabIndex = 47;
            this.progressBar.Visible = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // DecryptFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 561);
            this.Controls.Add(this.folderpathTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.hashGroupBox);
            this.Controls.Add(this.browseOutputButton);
            this.Controls.Add(this.aesPathTextBox);
            this.Controls.Add(this.selectKeyLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.browseAESKeyButton);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.browseInputButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DecryptFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.Load += new System.EventHandler(this.DecryptFile_Load);
            this.hashGroupBox.ResumeLayout(false);
            this.hashGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.OpenFileDialog openInputFileDialog;
        private System.Windows.Forms.Button browseInputButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button browseAESKeyButton;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label selectKeyLabel;
        private System.Windows.Forms.TextBox aesPathTextBox;
        private System.Windows.Forms.OpenFileDialog openAESFileDialog;
        private System.Windows.Forms.ToolTip decryptTooltip;
        private System.Windows.Forms.Label selectPubKeyLabel;
        private System.Windows.Forms.ComboBox usersComboBox;
        private System.Windows.Forms.GroupBox hashGroupBox;
        private System.Windows.Forms.TextBox hashPathTextBox;
        private System.Windows.Forms.Label selectHashLabel;
        private System.Windows.Forms.Button browseHashButton;
        private System.Windows.Forms.OpenFileDialog openHashFileDialog;
        private System.Windows.Forms.Label hashStatusLabel;
        private System.Windows.Forms.Label hashCheckLabel;
        private System.Windows.Forms.TextBox folderpathTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button browseOutputButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label waitLabel;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}