namespace BasicSec04
{
    partial class ChoiceMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceMenu));
            this.questionLabel = new System.Windows.Forms.Label();
            this.encryptFile = new System.Windows.Forms.Button();
            this.encryptMessage = new System.Windows.Forms.Button();
            this.exitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.White;
            this.questionLabel.Location = new System.Drawing.Point(50, 25);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(273, 45);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "What would you like to encrypt?";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // encryptFile
            // 
            this.encryptFile.BackColor = System.Drawing.Color.DimGray;
            this.encryptFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encryptFile.FlatAppearance.BorderSize = 2;
            this.encryptFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptFile.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.encryptFile.ForeColor = System.Drawing.Color.White;
            this.encryptFile.Location = new System.Drawing.Point(37, 89);
            this.encryptFile.Name = "encryptFile";
            this.encryptFile.Size = new System.Drawing.Size(139, 32);
            this.encryptFile.TabIndex = 50;
            this.encryptFile.Text = "A file";
            this.encryptFile.UseVisualStyleBackColor = false;
            this.encryptFile.Click += new System.EventHandler(this.encryptFile_Click);
            // 
            // encryptMessage
            // 
            this.encryptMessage.BackColor = System.Drawing.Color.DimGray;
            this.encryptMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encryptMessage.FlatAppearance.BorderSize = 2;
            this.encryptMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptMessage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.encryptMessage.ForeColor = System.Drawing.Color.White;
            this.encryptMessage.Location = new System.Drawing.Point(207, 89);
            this.encryptMessage.Name = "encryptMessage";
            this.encryptMessage.Size = new System.Drawing.Size(139, 32);
            this.encryptMessage.TabIndex = 51;
            this.encryptMessage.Text = "Simple Message";
            this.encryptMessage.UseVisualStyleBackColor = false;
            this.encryptMessage.Click += new System.EventHandler(this.encryptMessage_Click);
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Transparent;
            this.exitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(345, 9);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(23, 23);
            this.exitLabel.TabIndex = 52;
            this.exitLabel.Text = "X";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // ChoiceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(380, 173);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.encryptMessage);
            this.Controls.Add(this.encryptFile);
            this.Controls.Add(this.questionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 173);
            this.Name = "ChoiceMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose your method";
            this.Load += new System.EventHandler(this.ChoiceMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button encryptFile;
        private System.Windows.Forms.Button encryptMessage;
        private System.Windows.Forms.Label exitLabel;
    }
}