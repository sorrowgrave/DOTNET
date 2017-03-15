using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Threading;
using System.Diagnostics;
using System.Drawing.Printing;

namespace DrivingPXL
{
    //Form voor zowel het examen als oefenexamen af te leggen.
    //Date: 15/04/2014 23:10
    //Author: Niels Carmans
    public partial class OefenExamen : Form
    {
        string antwoord;
        string[][] quest;
        string[] foutief = new string[52];
        int i = 0;
        int fouten = 0;
        int score = 0;
        public int vragenlijst;
        private Font printFont;
        private StreamReader streamToPrint;
        DialogResult dialogResult;

        public OefenExamen()
        {
            InitializeComponent();
            
                this.Cursor = NativeMethods.LoadCustomCursor(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\misc\\verkeersborden\\car.ani");
            

            beginLabel.BackColor = Color.FromArgb(1, 100, 139);
            nextLabel.BackColor = Color.FromArgb(1, 100, 139);
            stopLabel.BackColor = Color.FromArgb(1, 100, 139);

        }

        private void beginLabel_Click(object sender, EventArgs e)
        {
            optieARadioButton.Checked = false;
            optieBRadioButton.Checked = false;
            optieCRadioButton.Checked = false;
            optieARadioButton.AutoCheck = true;
            optieBRadioButton.AutoCheck = true;
            optieCRadioButton.AutoCheck = true;

            tijdLbl.Text = "00 : 15";
            tijdProgressBar.Value = 0;
            beginLabel.Visible = false;
            uitvoerLabel.Text = "";

            vragen vraag = new vragen();

            try
            {
                if (dialogResult == DialogResult.Yes)
                {
                    if (i == 0)
                        i = 1;
                    quest = vraag.stelVraag(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\Users\\" + Variables.email + "\\fouten.txt");
                }
                else
                {
                    quest = vraag.stelVraag(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\Misc\\Vragenlijsten\\DATA" + vragenlijst + ".CFG");
                }

                if (quest[i] != null)
                {
                    vraag.Nummer = i;
                    if(dialogResult == DialogResult.Yes)
                        vraagNummerLabel.Text = "Vraag " + (i) + ":";
                    else
                        vraagNummerLabel.Text = "Vraag " + (i + 1) + ":";
                    vraagLabel.Text = quest[i][1];
                    if (dialogResult == DialogResult.Yes)
                    {
                        verkeersBordPictureBox.Image = Image.FromFile((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPxl\\Misc\\Verkeerssituaties\\" + quest[0][0] + "\\" + (quest[i][0]).Substring(0, 3) + ".jpg"));
                    }
                    else
                    {
                        verkeersBordPictureBox.Image = Image.FromFile((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPxl\\Misc\\Verkeerssituaties\\" + vragenlijst + "\\" + (quest[i][0]).Substring(0, 3) + ".jpg"));
                    }
                    optieARadioButton.Visible = false;
                    optieBRadioButton.Visible = false;

                    optieARadioButton.Text = quest[i][2];
                    optieBRadioButton.Text = quest[i][3];
                    optieARadioButton.Visible = true;
                    optieBRadioButton.Visible = true;


                    if (quest[i][5] == "A" || quest[i][5] == "B" || quest[i][5] == "C")
                    {
                        optieCRadioButton.Visible = true;
                        optieCRadioButton.Text = quest[i][4];
                        antwoord = quest[i][5];
                    }
                    else
                    {
                        optieCRadioButton.Visible = false;
                        antwoord = quest[i][4];
                    }

                    nextLabel.Visible = true;
                    tijdProgressBar.Value = 0;
                    delayTimer.Start();

                }
                else
                {
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\Users\\" + Variables.email;
                    if (fouten != 0)
                    {
                        FileStream Fouten = new FileStream(path + "\\fouten.txt", FileMode.OpenOrCreate, FileAccess.Write);
                        Fouten.Close();
                        File.WriteAllLines(path + "\\fouten.txt", foutief);
                        fouten--;
                    }

                    FileStream scores = new FileStream(path + "\\scores.txt", FileMode.OpenOrCreate, FileAccess.Write);
                    scores.Close();
                    StreamWriter writeScores = File.AppendText(path + "\\scores.txt");
                    string now = DateTime.Now.ToString("dd/MM/yy HH:mm");
                    writeScores.Write(now + ";" + score + Environment.NewLine);
                    writeScores.Close();
                    if (Variables.examen == true)
                    {
                        string[] lines = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\Misc\\Templates\\Geslaagd.txt");

                        lines[35] = string.Format("{0,-15} {1}", "Voornaam", ": " + Variables.name);
                        lines[36] = string.Format("{0,-15} {1}", "Naam", ": " + Variables.surname);
                        lines[37] = string.Format("{0,-15} {1}", "Geboortedatum", ": " + Variables.birthDate);
                        lines[38] = string.Format("{0,-15} {1}", "Postcode", ": " + Variables.postalCode);
                        lines[39] = string.Format("{0,-15} {1}", "Vragenreeks", ": " + vragenlijst);
                        if (score >= 41)
                            lines[40] = string.Format("{0,-15} {1}", "Resultaat", ": " + "Geslaagd");
                        else
                            lines[40] = string.Format("{0,-15} {1}", "Resultaat", ": " + "Niet geslaagd");
                        lines[41] = string.Format("{0,-15} {1}", "Overtredingen", ": " + fouten);
                        lines[42] = string.Format("{0,-15} {1}", "Score", ": " + score);

                        FileStream geslaagd = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\Users\\" + Variables.email + "\\Geslaagd.txt", FileMode.OpenOrCreate, FileAccess.Write);
                        geslaagd.Close();
                        File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\Users\\" + Variables.email + "\\Geslaagd.txt", lines);

                        SendEmail mail = new SendEmail();

                        mail.EmailSend(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\Users\\" + Variables.email + "\\Geslaagd.txt", Variables.email, Variables.name, Variables.surname);
                        Printing();
                    }

                    Variables.examen = false;
                    Menu menu = new Menu();
                    menu.Show();
                    this.Close();

                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found, please check your directory. Or reinstall");
                Menu menu = new Menu();
                menu.Show();
                this.Close();
            }
            catch(DirectoryNotFoundException){
                MessageBox.Show("User not found, try registering again.");
                Login login = new Login();
                login.Show();
                this.Close();
            }
           

                
        }

        static class NativeMethods
        {
            public static Cursor LoadCustomCursor(string path)
            {
                try
                {

                    IntPtr hCurs = LoadCursorFromFile(path);
                    if (hCurs == IntPtr.Zero) throw new FileNotFoundException();
                    var curs = new Cursor(hCurs);
                    // Note: force the cursor to own the handle so it gets released properly
                    var fi = typeof(Cursor).GetField("ownHandle", BindingFlags.NonPublic | BindingFlags.Instance);
                    fi.SetValue(curs, true);
                    return curs;
                
                }
                catch(FileNotFoundException)
                {
                   return Cursors.Arrow;
                }

            }
            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            private static extern IntPtr LoadCursorFromFile(string path);
        }

        private void OefenExamen_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\Users\\" + Variables.email + "\\fouten.txt";

            if(Variables.examen==true)
            {
                examenLabel.Visible = true;
                uitvoerLabel.Visible = false;
            }
            else
            {
                if (File.Exists(path) && new FileInfo(path).Length != 0)
                {
                    dialogResult = MessageBox.Show("Wilt u uw fouten van vorige keer herhalen?", "", MessageBoxButtons.YesNo);
                }
            }
            nextLabel.Visible = false;
            timer1.Interval = 15000;
            delayTimer.Interval = 3500;
            delayTimer2.Interval = 3500;
            progressTimer.Interval = 1000;
            tijdProgressBar.Maximum = 15;
            tijdProgressBar.Minimum = 0;
            tijdProgressBar.Step = 1;
            tijdProgressBar.Value = 0;

            Random rnd = new Random();
            vragenlijst = rnd.Next(1, 5);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Get the BackgroundWorker that raised this event.
            BackgroundWorker worker = sender as BackgroundWorker;
            beginLabel_Click(sender, e);

        }
        private void nextLabel_Click(object sender, EventArgs e)
        {
            progressTimer.Stop();
            delayTimer.Stop();
            vragen vraag = new vragen();

            int neem;

            if (quest[i][5] == "C" || quest[i][5] == "A" || quest[i][5] == "B")
            {
                neem = 6;
            }
            else
            {
                neem = 5;
            }

            var checkedButton = antwoordenGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton != null) 
            { 
                if ((checkedButton.Name).Substring(5, 1) == quest[i][neem - 1])
                {
                    uitvoerLabel.Text = "Correct, " + quest[i][neem];
                    score++;
                }
                else
                {
                    schrijfFouten(neem, quest);

                } 
                
            }
            else
            {
                 schrijfFouten(neem, quest);
                
            } 
            
            
            uitvoerLabel.Refresh();
            i++;
            if (Variables.examen == true)
            {
                beginLabel_Click(sender, e);
            }
            else
            {
                delayTimer2.Start();
            }

            //beginLabel_Click(sender, e);

        }

        public void schrijfFouten(int neem, string[][] quest)
        {
            uitvoerLabel.Text = "Fout, " + quest[i][neem];
            uitvoerLabel.Refresh();
            if (fouten == 0)
            {
                foutief[fouten] = Convert.ToString(vragenlijst);
                fouten++;
            }
            for (int k = 0; k <= neem; k++)
            {
                foutief[fouten] = foutief[fouten] + quest[i][k] + ";";
            }
            fouten++;

        }
        private void progressTimer_Tick(object sender, EventArgs e)
        {
            if (tijdProgressBar.Value < 15)
            {
                tijdProgressBar.Value++;

                if (tijdProgressBar.Value <= 5)
                    tijdLbl.Text = "00 : " + Convert.ToString(15 - tijdProgressBar.Value);
                else
                    tijdLbl.Text = "00 : 0" + Convert.ToString(15 - tijdProgressBar.Value);     
            }
            else
            {
                nextLabel_Click(sender, e);
                progressTimer.Stop();
                    
            }
        }
        private void delayTimer_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            progressTimer.Start();
            delayTimer.Stop();
        }

        private void delayTimer2_Tick(object sender, EventArgs e)
        {
            beginLabel_Click(sender, e);
            delayTimer2.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nextLabel_Click(sender, e);
            timer1.Stop();
        }

        private void stopLabel_MouseHover(object sender, EventArgs e)
        {
            stopLabel.BackColor = Color.FromArgb(11, 134, 168);
        }

        private void nextLabel_MouseHover(object sender, EventArgs e)
        {
            nextLabel.BackColor = Color.FromArgb(11, 134, 168);
        }

        private void beginLabel_MouseHover(object sender, EventArgs e)
        {
            beginLabel.BackColor = Color.FromArgb(11, 134, 168);
        }
        private void nextLabel_MouseLeave(object sender, EventArgs e)
        {
            nextLabel.BackColor = Color.FromArgb(1, 100, 139);
        }

        private void beginLabel_MouseLeave(object sender, EventArgs e)
        {
            beginLabel.BackColor = Color.FromArgb(1, 100, 139);
        }

        private void stopLabel_MouseLeave(object sender, EventArgs e)
        {
            stopLabel.BackColor = Color.FromArgb(1, 100, 139);
        }
        private void stopLabel_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = 10;
            float topMargin = 10;
            String line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Iterate over the file, printing each line. 
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page. 
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }


        public void Printing()
        {

            try
            {
                streamToPrint = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\Users\\" + Variables.email + "\\Geslaagd.txt");

                    printFont = new Font("Consolas",  (float)9.5);
                    PrintDocument pd = new PrintDocument();
                    PrintDialog PrintDialog = new PrintDialog();
                    if (PrintDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        pd.PrinterSettings.PrinterName = printDialog.PrinterSettings.PrinterName;
                        pd.DefaultPageSettings.Margins.Bottom = 0;
                        pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
                        // Set the page orientation to landscape.
                        pd.DefaultPageSettings.Landscape = true;
                        pd.Print();
                    }
                
                
            }
            catch(InvalidPrinterException){
                MessageBox.Show("Printer not found, please check your printer settings");
                Menu menu = new Menu();
                menu.Show();
                this.Close();
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("File not found, please check your directory. Or reinstall");
                Menu menu = new Menu();
                menu.Show();
                this.Close();
            }
            finally
            {
                 streamToPrint.Close();
                 
            }
        }

        
    }
}
