namespace DrivingPXL
{
    partial class OefenExamen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /*protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OefenExamen));
            this.vraagNummerLabel = new System.Windows.Forms.Label();
            this.vraagLabel = new System.Windows.Forms.Label();
            this.antwoordenGroupBox = new System.Windows.Forms.GroupBox();
            this.optieCRadioButton = new System.Windows.Forms.RadioButton();
            this.optieBRadioButton = new System.Windows.Forms.RadioButton();
            this.optieARadioButton = new System.Windows.Forms.RadioButton();
            this.verkeersBordPictureBox = new System.Windows.Forms.PictureBox();
            this.uitvoerLabel = new System.Windows.Forms.Label();
            this.tijdProgressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nextLabel = new System.Windows.Forms.Button();
            this.beginLabel = new System.Windows.Forms.Button();
            this.stopLabel = new System.Windows.Forms.Button();
            this.tijdLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.delayTimer = new System.Windows.Forms.Timer(this.components);
            this.delayTimer2 = new System.Windows.Forms.Timer(this.components);
            this.examenLabel = new System.Windows.Forms.Label();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.antwoordenGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verkeersBordPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // vraagNummerLabel
            // 
            this.vraagNummerLabel.AutoSize = true;
            this.vraagNummerLabel.BackColor = System.Drawing.Color.Transparent;
            this.vraagNummerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vraagNummerLabel.ForeColor = System.Drawing.Color.White;
            this.vraagNummerLabel.Location = new System.Drawing.Point(49, 48);
            this.vraagNummerLabel.Name = "vraagNummerLabel";
            this.vraagNummerLabel.Size = new System.Drawing.Size(51, 21);
            this.vraagNummerLabel.TabIndex = 0;
            this.vraagNummerLabel.Text = "Vraag";
            // 
            // vraagLabel
            // 
            this.vraagLabel.BackColor = System.Drawing.Color.Transparent;
            this.vraagLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vraagLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vraagLabel.ForeColor = System.Drawing.Color.White;
            this.vraagLabel.Location = new System.Drawing.Point(53, 77);
            this.vraagLabel.Name = "vraagLabel";
            this.vraagLabel.Size = new System.Drawing.Size(515, 75);
            this.vraagLabel.TabIndex = 1;
            this.vraagLabel.Text = "Hier komen de vragen te staan.";
            // 
            // antwoordenGroupBox
            // 
            this.antwoordenGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.antwoordenGroupBox.Controls.Add(this.optieCRadioButton);
            this.antwoordenGroupBox.Controls.Add(this.optieBRadioButton);
            this.antwoordenGroupBox.Controls.Add(this.optieARadioButton);
            this.antwoordenGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antwoordenGroupBox.ForeColor = System.Drawing.Color.White;
            this.antwoordenGroupBox.Location = new System.Drawing.Point(53, 155);
            this.antwoordenGroupBox.Name = "antwoordenGroupBox";
            this.antwoordenGroupBox.Size = new System.Drawing.Size(515, 228);
            this.antwoordenGroupBox.TabIndex = 2;
            this.antwoordenGroupBox.TabStop = false;
            this.antwoordenGroupBox.Text = "Antwoorden";
            // 
            // optieCRadioButton
            // 
            this.optieCRadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optieCRadioButton.Location = new System.Drawing.Point(17, 154);
            this.optieCRadioButton.Name = "optieCRadioButton";
            this.optieCRadioButton.Size = new System.Drawing.Size(498, 57);
            this.optieCRadioButton.TabIndex = 2;
            this.optieCRadioButton.TabStop = true;
            this.optieCRadioButton.Text = "niets";
            this.optieCRadioButton.UseVisualStyleBackColor = true;
            // 
            // optieBRadioButton
            // 
            this.optieBRadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optieBRadioButton.Location = new System.Drawing.Point(17, 91);
            this.optieBRadioButton.Name = "optieBRadioButton";
            this.optieBRadioButton.Size = new System.Drawing.Size(498, 57);
            this.optieBRadioButton.TabIndex = 1;
            this.optieBRadioButton.TabStop = true;
            this.optieBRadioButton.Text = "remmen";
            this.optieBRadioButton.UseVisualStyleBackColor = true;
            // 
            // optieARadioButton
            // 
            this.optieARadioButton.FlatAppearance.BorderSize = 3;
            this.optieARadioButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optieARadioButton.Location = new System.Drawing.Point(17, 28);
            this.optieARadioButton.Name = "optieARadioButton";
            this.optieARadioButton.Size = new System.Drawing.Size(498, 57);
            this.optieARadioButton.TabIndex = 0;
            this.optieARadioButton.TabStop = true;
            this.optieARadioButton.Text = "gas loslaten";
            this.optieARadioButton.UseVisualStyleBackColor = true;
            // 
            // verkeersBordPictureBox
            // 
            this.verkeersBordPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.verkeersBordPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verkeersBordPictureBox.BackgroundImage")));
            this.verkeersBordPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verkeersBordPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verkeersBordPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("verkeersBordPictureBox.InitialImage")));
            this.verkeersBordPictureBox.Location = new System.Drawing.Point(586, 111);
            this.verkeersBordPictureBox.Name = "verkeersBordPictureBox";
            this.verkeersBordPictureBox.Size = new System.Drawing.Size(445, 335);
            this.verkeersBordPictureBox.TabIndex = 6;
            this.verkeersBordPictureBox.TabStop = false;
            // 
            // uitvoerLabel
            // 
            this.uitvoerLabel.BackColor = System.Drawing.Color.Transparent;
            this.uitvoerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uitvoerLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.uitvoerLabel.ForeColor = System.Drawing.Color.White;
            this.uitvoerLabel.Location = new System.Drawing.Point(53, 400);
            this.uitvoerLabel.Name = "uitvoerLabel";
            this.uitvoerLabel.Size = new System.Drawing.Size(515, 93);
            this.uitvoerLabel.TabIndex = 0;
            this.uitvoerLabel.Text = "Bij het beantwoorden van de vraag wordt hier weergegeven of de vraag juist of fou" +
    "t is, met extra uitleg.";
            // 
            // tijdProgressBar
            // 
            this.tijdProgressBar.Location = new System.Drawing.Point(586, 80);
            this.tijdProgressBar.Name = "tijdProgressBar";
            this.tijdProgressBar.Size = new System.Drawing.Size(445, 23);
            this.tijdProgressBar.TabIndex = 7;
            // 
            // nextLabel
            // 
            this.nextLabel.BackColor = System.Drawing.Color.Transparent;
            this.nextLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextLabel.FlatAppearance.BorderSize = 2;
            this.nextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nextLabel.ForeColor = System.Drawing.Color.White;
            this.nextLabel.Location = new System.Drawing.Point(118, 535);
            this.nextLabel.Name = "nextLabel";
            this.nextLabel.Size = new System.Drawing.Size(90, 32);
            this.nextLabel.TabIndex = 10;
            this.nextLabel.Text = "Next";
            this.nextLabel.UseVisualStyleBackColor = false;
            this.nextLabel.Visible = false;
            this.nextLabel.Click += new System.EventHandler(this.nextLabel_Click);
            this.nextLabel.MouseLeave += new System.EventHandler(this.nextLabel_MouseLeave);
            this.nextLabel.MouseHover += new System.EventHandler(this.nextLabel_MouseHover);
            // 
            // beginLabel
            // 
            this.beginLabel.BackColor = System.Drawing.Color.Transparent;
            this.beginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.beginLabel.FlatAppearance.BorderSize = 2;
            this.beginLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.beginLabel.ForeColor = System.Drawing.Color.White;
            this.beginLabel.Location = new System.Drawing.Point(118, 535);
            this.beginLabel.Name = "beginLabel";
            this.beginLabel.Size = new System.Drawing.Size(90, 32);
            this.beginLabel.TabIndex = 11;
            this.beginLabel.Text = "Begin";
            this.beginLabel.UseVisualStyleBackColor = false;
            this.beginLabel.Click += new System.EventHandler(this.beginLabel_Click);
            this.beginLabel.MouseLeave += new System.EventHandler(this.beginLabel_MouseLeave);
            this.beginLabel.MouseHover += new System.EventHandler(this.beginLabel_MouseHover);
            // 
            // stopLabel
            // 
            this.stopLabel.BackColor = System.Drawing.Color.Transparent;
            this.stopLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopLabel.FlatAppearance.BorderSize = 2;
            this.stopLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.stopLabel.ForeColor = System.Drawing.Color.White;
            this.stopLabel.Location = new System.Drawing.Point(231, 535);
            this.stopLabel.Name = "stopLabel";
            this.stopLabel.Size = new System.Drawing.Size(90, 32);
            this.stopLabel.TabIndex = 12;
            this.stopLabel.Text = "Stop";
            this.stopLabel.UseVisualStyleBackColor = false;
            this.stopLabel.Click += new System.EventHandler(this.stopLabel_Click);
            this.stopLabel.MouseLeave += new System.EventHandler(this.stopLabel_MouseLeave);
            this.stopLabel.MouseHover += new System.EventHandler(this.stopLabel_MouseHover);
            // 
            // tijdLbl
            // 
            this.tijdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tijdLbl.AutoSize = true;
            this.tijdLbl.BackColor = System.Drawing.Color.Transparent;
            this.tijdLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tijdLbl.ForeColor = System.Drawing.Color.White;
            this.tijdLbl.Location = new System.Drawing.Point(686, 463);
            this.tijdLbl.Name = "tijdLbl";
            this.tijdLbl.Size = new System.Drawing.Size(74, 30);
            this.tijdLbl.TabIndex = 13;
            this.tijdLbl.Text = "00 : 15";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(581, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Time left:";
            // 
            // progressTimer
            // 
            this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
            // 
            // delayTimer
            // 
            this.delayTimer.Tick += new System.EventHandler(this.delayTimer_Tick);
            // 
            // delayTimer2
            // 
            this.delayTimer2.Tick += new System.EventHandler(this.delayTimer2_Tick);
            // 
            // examenLabel
            // 
            this.examenLabel.BackColor = System.Drawing.Color.Transparent;
            this.examenLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examenLabel.ForeColor = System.Drawing.Color.White;
            this.examenLabel.Location = new System.Drawing.Point(0, 9);
            this.examenLabel.Name = "examenLabel";
            this.examenLabel.Size = new System.Drawing.Size(1080, 37);
            this.examenLabel.TabIndex = 15;
            this.examenLabel.Text = "Examen";
            this.examenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.examenLabel.Visible = false;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // OefenExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1080, 597);
            this.Controls.Add(this.uitvoerLabel);
            this.Controls.Add(this.examenLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tijdLbl);
            this.Controls.Add(this.stopLabel);
            this.Controls.Add(this.beginLabel);
            this.Controls.Add(this.nextLabel);
            this.Controls.Add(this.tijdProgressBar);
            this.Controls.Add(this.verkeersBordPictureBox);
            this.Controls.Add(this.antwoordenGroupBox);
            this.Controls.Add(this.vraagLabel);
            this.Controls.Add(this.vraagNummerLabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1080, 597);
            this.Name = "OefenExamen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rijexamen";
            this.Load += new System.EventHandler(this.OefenExamen_Load);
            this.antwoordenGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.verkeersBordPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vraagNummerLabel;
        private System.Windows.Forms.Label vraagLabel;
        private System.Windows.Forms.GroupBox antwoordenGroupBox;
        private System.Windows.Forms.RadioButton optieCRadioButton;
        private System.Windows.Forms.RadioButton optieBRadioButton;
        private System.Windows.Forms.RadioButton optieARadioButton;
        private System.Windows.Forms.PictureBox verkeersBordPictureBox;
        private System.Windows.Forms.Label uitvoerLabel;
        private System.Windows.Forms.ProgressBar tijdProgressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button nextLabel;
        private System.Windows.Forms.Button beginLabel;
        private System.Windows.Forms.Button stopLabel;
        private System.Windows.Forms.Label tijdLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.Timer delayTimer;
        private System.Windows.Forms.Timer delayTimer2;
        private System.Windows.Forms.Label examenLabel;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}

