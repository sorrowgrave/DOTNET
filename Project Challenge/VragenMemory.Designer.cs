namespace DrivingPXL
{
    partial class VragenMemory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VragenMemory));
            this.answersGroupBox = new System.Windows.Forms.GroupBox();
            this.antwoord3Radiobutton = new System.Windows.Forms.RadioButton();
            this.antwoord2Radiobutton = new System.Windows.Forms.RadioButton();
            this.antwoord1Radiobutton = new System.Windows.Forms.RadioButton();
            this.imageLabel = new System.Windows.Forms.Label();
            this.antwoordLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.answersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // answersGroupBox
            // 
            this.answersGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.answersGroupBox.Controls.Add(this.antwoord3Radiobutton);
            this.answersGroupBox.Controls.Add(this.antwoord2Radiobutton);
            this.answersGroupBox.Controls.Add(this.antwoord1Radiobutton);
            this.answersGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answersGroupBox.ForeColor = System.Drawing.Color.White;
            this.answersGroupBox.Location = new System.Drawing.Point(59, 261);
            this.answersGroupBox.Name = "answersGroupBox";
            this.answersGroupBox.Size = new System.Drawing.Size(482, 254);
            this.answersGroupBox.TabIndex = 6;
            this.answersGroupBox.TabStop = false;
            this.answersGroupBox.Text = "Answers";
            // 
            // antwoord3Radiobutton
            // 
            this.antwoord3Radiobutton.Location = new System.Drawing.Point(33, 164);
            this.antwoord3Radiobutton.Name = "antwoord3Radiobutton";
            this.antwoord3Radiobutton.Size = new System.Drawing.Size(443, 53);
            this.antwoord3Radiobutton.TabIndex = 0;
            this.antwoord3Radiobutton.TabStop = true;
            this.antwoord3Radiobutton.UseVisualStyleBackColor = true;
            this.antwoord3Radiobutton.CheckedChanged += new System.EventHandler(this.radioButton);
            // 
            // antwoord2Radiobutton
            // 
            this.antwoord2Radiobutton.Location = new System.Drawing.Point(33, 98);
            this.antwoord2Radiobutton.Name = "antwoord2Radiobutton";
            this.antwoord2Radiobutton.Size = new System.Drawing.Size(443, 53);
            this.antwoord2Radiobutton.TabIndex = 0;
            this.antwoord2Radiobutton.TabStop = true;
            this.antwoord2Radiobutton.UseVisualStyleBackColor = true;
            this.antwoord2Radiobutton.CheckedChanged += new System.EventHandler(this.radioButton);
            // 
            // antwoord1Radiobutton
            // 
            this.antwoord1Radiobutton.Location = new System.Drawing.Point(33, 28);
            this.antwoord1Radiobutton.Name = "antwoord1Radiobutton";
            this.antwoord1Radiobutton.Size = new System.Drawing.Size(443, 53);
            this.antwoord1Radiobutton.TabIndex = 0;
            this.antwoord1Radiobutton.TabStop = true;
            this.antwoord1Radiobutton.UseVisualStyleBackColor = true;
            this.antwoord1Radiobutton.CheckedChanged += new System.EventHandler(this.radioButton);
            // 
            // imageLabel
            // 
            this.imageLabel.BackColor = System.Drawing.Color.Transparent;
            this.imageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageLabel.ForeColor = System.Drawing.Color.White;
            this.imageLabel.Location = new System.Drawing.Point(244, 49);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(125, 125);
            this.imageLabel.TabIndex = 5;
            // 
            // antwoordLabel
            // 
            this.antwoordLabel.BackColor = System.Drawing.Color.Transparent;
            this.antwoordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antwoordLabel.ForeColor = System.Drawing.Color.White;
            this.antwoordLabel.Location = new System.Drawing.Point(59, 206);
            this.antwoordLabel.Name = "antwoordLabel";
            this.antwoordLabel.Size = new System.Drawing.Size(482, 52);
            this.antwoordLabel.TabIndex = 8;
            this.antwoordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderSize = 2;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(451, 542);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 32);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Transparent;
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.FlatAppearance.BorderSize = 2;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(344, 542);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(90, 32);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // VragenMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(611, 624);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.answersGroupBox);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.antwoordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(611, 624);
            this.Name = "VragenMemory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VragenMemory";
            this.Load += new System.EventHandler(this.VragenMemory_Load);
            this.answersGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox answersGroupBox;
        private System.Windows.Forms.RadioButton antwoord3Radiobutton;
        private System.Windows.Forms.RadioButton antwoord2Radiobutton;
        private System.Windows.Forms.RadioButton antwoord1Radiobutton;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Label antwoordLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button nextButton;

    }
}