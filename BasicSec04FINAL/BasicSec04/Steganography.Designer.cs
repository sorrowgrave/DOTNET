namespace BasicSec04
{
    partial class Steganography
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Steganography));
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.saveTextButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.getPictureButton = new System.Windows.Forms.Button();
            this.fotoPicturebox = new System.Windows.Forms.PictureBox();
            this.extractButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.messageTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.messageTextBox.Location = new System.Drawing.Point(51, 81);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(342, 216);
            this.messageTextBox.TabIndex = 0;
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
            // saveTextButton
            // 
            this.saveTextButton.BackColor = System.Drawing.Color.DimGray;
            this.saveTextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveTextButton.FlatAppearance.BorderSize = 2;
            this.saveTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveTextButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.saveTextButton.ForeColor = System.Drawing.Color.White;
            this.saveTextButton.Location = new System.Drawing.Point(51, 309);
            this.saveTextButton.Name = "saveTextButton";
            this.saveTextButton.Size = new System.Drawing.Size(90, 32);
            this.saveTextButton.TabIndex = 30;
            this.saveTextButton.Text = "Save text";
            this.saveTextButton.UseVisualStyleBackColor = false;
            this.saveTextButton.Click += new System.EventHandler(this.saveTextButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // getPictureButton
            // 
            this.getPictureButton.BackColor = System.Drawing.Color.DimGray;
            this.getPictureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getPictureButton.FlatAppearance.BorderSize = 2;
            this.getPictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getPictureButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.getPictureButton.ForeColor = System.Drawing.Color.White;
            this.getPictureButton.Location = new System.Drawing.Point(399, 309);
            this.getPictureButton.Name = "getPictureButton";
            this.getPictureButton.Size = new System.Drawing.Size(115, 32);
            this.getPictureButton.TabIndex = 31;
            this.getPictureButton.Text = "Get picture";
            this.getPictureButton.UseVisualStyleBackColor = false;
            this.getPictureButton.Click += new System.EventHandler(this.getPictureButton_Click);
            // 
            // fotoPicturebox
            // 
            this.fotoPicturebox.BackColor = System.Drawing.Color.Transparent;
            this.fotoPicturebox.Image = global::BasicSec04.Properties.Resources.Drag_Drop;
            this.fotoPicturebox.Location = new System.Drawing.Point(399, 81);
            this.fotoPicturebox.Name = "fotoPicturebox";
            this.fotoPicturebox.Size = new System.Drawing.Size(342, 216);
            this.fotoPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoPicturebox.TabIndex = 32;
            this.fotoPicturebox.TabStop = false;
            // 
            // extractButton
            // 
            this.extractButton.BackColor = System.Drawing.Color.DimGray;
            this.extractButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.extractButton.FlatAppearance.BorderSize = 2;
            this.extractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extractButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.extractButton.ForeColor = System.Drawing.Color.White;
            this.extractButton.Location = new System.Drawing.Point(627, 309);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(114, 32);
            this.extractButton.TabIndex = 33;
            this.extractButton.Text = "Extract text";
            this.extractButton.UseVisualStyleBackColor = false;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(278, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 32);
            this.button1.TabIndex = 34;
            this.button1.Text = "Import text";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(627, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 32);
            this.button2.TabIndex = 35;
            this.button2.Text = "Export text";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Steganography
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 559);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.extractButton);
            this.Controls.Add(this.fotoPicturebox);
            this.Controls.Add(this.getPictureButton);
            this.Controls.Add(this.saveTextButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.messageTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Steganography";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Steganography_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Steganography_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.fotoPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button exitButton;

        private System.Windows.Forms.Button saveTextButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button getPictureButton;
        private System.Windows.Forms.PictureBox fotoPicturebox;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;


    }
}