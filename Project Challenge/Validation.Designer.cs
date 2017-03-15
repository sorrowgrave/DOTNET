namespace DrivingPXL
{
    partial class Validation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Validation));
            this.cancelButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.receipentLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.validationMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.resendButton = new System.Windows.Forms.Button();
            this.sendingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderSize = 2;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(670, 489);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 32);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelBtn_Click);
            this.cancelButton.MouseLeave += new System.EventHandler(this.cancelBtn_MouseLeave);
            this.cancelButton.MouseHover += new System.EventHandler(this.cancelBtn_MouseHover);
            // 
            // finishButton
            // 
            this.finishButton.BackColor = System.Drawing.Color.Transparent;
            this.finishButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finishButton.FlatAppearance.BorderSize = 2;
            this.finishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.finishButton.ForeColor = System.Drawing.Color.White;
            this.finishButton.Location = new System.Drawing.Point(563, 489);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(90, 32);
            this.finishButton.TabIndex = 21;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = false;
            this.finishButton.Click += new System.EventHandler(this.finishBtn_Click);
            this.finishButton.MouseLeave += new System.EventHandler(this.finishBtn_MouseLeave);
            this.finishButton.MouseHover += new System.EventHandler(this.finishBtn_MouseHover);
            // 
            // receipentLabel
            // 
            this.receipentLabel.AllowDrop = true;
            this.receipentLabel.BackColor = System.Drawing.Color.Transparent;
            this.receipentLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.receipentLabel.ForeColor = System.Drawing.Color.White;
            this.receipentLabel.Location = new System.Drawing.Point(1, 35);
            this.receipentLabel.Name = "receipentLabel";
            this.receipentLabel.Size = new System.Drawing.Size(821, 32);
            this.receipentLabel.TabIndex = 23;
            this.receipentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(285, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 46);
            this.label2.TabIndex = 24;
            this.label2.Text = "You will receive a validation code soon, please enter the code in the textbox abo" +
    "ve.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // validationMaskedTextBox
            // 
            this.validationMaskedTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validationMaskedTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.validationMaskedTextBox.Location = new System.Drawing.Point(355, 133);
            this.validationMaskedTextBox.Mask = "0000 0000";
            this.validationMaskedTextBox.Name = "validationMaskedTextBox";
            this.validationMaskedTextBox.PromptChar = ' ';
            this.validationMaskedTextBox.Size = new System.Drawing.Size(141, 34);
            this.validationMaskedTextBox.TabIndex = 0;
            this.validationMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.validationMaskedTextBox.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // resendButton
            // 
            this.resendButton.BackColor = System.Drawing.Color.Transparent;
            this.resendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resendButton.FlatAppearance.BorderSize = 2;
            this.resendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resendButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.resendButton.ForeColor = System.Drawing.Color.White;
            this.resendButton.Location = new System.Drawing.Point(54, 489);
            this.resendButton.Name = "resendButton";
            this.resendButton.Size = new System.Drawing.Size(186, 32);
            this.resendButton.TabIndex = 25;
            this.resendButton.Text = "Resend validation code";
            this.resendButton.UseVisualStyleBackColor = false;
            this.resendButton.Click += new System.EventHandler(this.resendButton_Click);
            this.resendButton.MouseLeave += new System.EventHandler(this.resendButton_MouseLeave);
            this.resendButton.MouseHover += new System.EventHandler(this.resendButton_MouseHover);
            // 
            // sendingLabel
            // 
            this.sendingLabel.AutoSize = true;
            this.sendingLabel.BackColor = System.Drawing.Color.Transparent;
            this.sendingLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sendingLabel.ForeColor = System.Drawing.Color.White;
            this.sendingLabel.Location = new System.Drawing.Point(468, 494);
            this.sendingLabel.Name = "sendingLabel";
            this.sendingLabel.Size = new System.Drawing.Size(85, 19);
            this.sendingLabel.TabIndex = 26;
            this.sendingLabel.Text = "Please wait...";
            this.sendingLabel.Visible = false;
            // 
            // Validation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 559);
            this.Controls.Add(this.sendingLabel);
            this.Controls.Add(this.resendButton);
            this.Controls.Add(this.validationMaskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.receipentLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.finishButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(821, 559);
            this.Name = "Validation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Label receipentLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox validationMaskedTextBox;
        private System.Windows.Forms.Button resendButton;
        private System.Windows.Forms.Label sendingLabel;
    }
}