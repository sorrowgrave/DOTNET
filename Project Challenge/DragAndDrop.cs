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
using System.Media;

namespace DrivingPXL
{
    //Form voor het genereren van random verkeersborden met bijhorende antwoorden die later gebruikt worden voor drag and drop mogelijkheden.
    //Date: 30/04/2014 13:23
    //Author: Olivier Quaethoven
    public partial class DragAndDrop : Form
    {
        Random random = new Random();
        Random random2 = new Random();
        List<string> icons = new List<string>();
        List<string> answers = new List<string>();
        int list;
        int[] choices = new int[6];
        bool release = false;
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\misc\\Vragenlijsten\\VragenMemory.txt";
        string[] images = new string[10];
        string[] controle = new string[6];
        string[] hulp;
        string passOn;

        public DragAndDrop()
        {

            InitializeComponent();
            checkButton.BackColor = Color.FromArgb(1, 100, 139);
            stopButton.BackColor = Color.FromArgb(1, 100, 139);
            int teller=0;
            int counter = 0;
            string[] lines;
            lines=File.ReadAllLines(path);
            list = random2.Next(1, 11);
            while(counter<10)
            {
                int randomNum = random.Next(1, 194);
                if (!(answers.Contains(Convert.ToString(randomNum))))
                {
                    icons.Add(Convert.ToString(randomNum + ".jpeg"));
                    answers.Add(Convert.ToString(randomNum));
                    counter++;
                }
            }

                //Inladen van afbeeldingen in de eerste table layout (deze is voor het kiezen van de afbeeldingen)
                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    Label iconLabel = control as Label;

                    if (iconLabel != null)
                    {

                        int randomNumber = random.Next(icons.Count);
                        images[teller] = icons[randomNumber];
                        iconLabel.Name = images[teller];
                        iconLabel.Image = Image.FromFile((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\misc\\Verkeersborden\\" +iconLabel.Name));
                        icons.RemoveAt(randomNumber);
                        teller++;

                    }
                }

                //Inladen van antwoorden in de tweede table layout (deze is voor het matchen van afbeeldingen met antwoorden)
                foreach (Control control in tableLayoutPanel2.Controls)
                {

                    Label tekstLabel = control as Label;
                    if (tekstLabel.TabIndex % 2 != 0)
                    {
                        hulp = (lines[Convert.ToInt32(answers[0]) - 1]).Split(';');
                        tekstLabel.Name = hulp[0];
                        tekstLabel.Text = @hulp[1];
                        answers.RemoveAt(0);

                    }
                    else
                        tekstLabel.BackColor = Color.FromArgb(11, 134, 168);
                }
            
            
            
        }

        public void testDragDrop()
        {
            //Voor elk item in de tweede table layout met een even tabindex word een allow drop ingesteld.
            foreach (Control control in tableLayoutPanel2.Controls)
            {
                
                Label iconLabel = control as Label;
                if (iconLabel.TabIndex % 2 == 0)
                {
                    iconLabel.AllowDrop = true;
                }
                
            }

            //Voor elk item in de eerst table layout word een allow drop ingesteld.
            foreach (Control control in tableLayoutPanel1.Controls)
            {

                Label iconLabel = control as Label;
                iconLabel.AllowDrop = true;
            }
        }

        private void DragAndDrop_Load(object sender, EventArgs e)
        {
            testDragDrop();
            
        }

        private void mogelijkheid1Label_MouseDown(object sender, MouseEventArgs e)
        {
            passOn = ((Label)sender).Name;
            try
            {
                ((Label)sender).DoDragDrop(((Label)sender).Image, DragDropEffects.Move);

                if (release)
                {

                    ((Label)sender).Image = null;
                    release = false;

                }
            }
            catch(NullReferenceException)
            {
                SystemSounds.Beep.Play();
            }

        }


        private void label7_DragEnter(object sender, DragEventArgs e)
        {  
            if (((Label)sender).Image != null){
                e.Effect = DragDropEffects.None;
            }
            else
            {
                e.Effect = e.AllowedEffect;
            }
                
        }

        private void label7_DragDrop(object sender, DragEventArgs e)
        {
            if (((Label)sender).Image == null)
            {
                ((Label)sender).Image = (Image)e.Data.GetData(DataFormats.Bitmap);
                release = true;
                ((Label)sender).Name = passOn;
            }

        }

        private void checkButton_MouseLeave(object sender, EventArgs e)
        {
            checkButton.BackColor = Color.FromArgb(1, 100, 139);
        }

        private void checkButton_MouseHover(object sender, EventArgs e)
        {
            checkButton.BackColor = Color.FromArgb(11, 134, 168);
        }


        private void checkButton_Click(object sender, EventArgs e)
        {
            Control[] test = new Control[6];
            Control[] antwoord = new Control[6];

            int p = 0;
            int a = 0;

            for (int i = 0; i < tableLayoutPanel2.RowCount; i++)
            {
                int m = 1;
                int g = 0;



                for (int j = 0; j < tableLayoutPanel2.ColumnCount / 2; j++)
                {
                    antwoord[p] = tableLayoutPanel2.GetControlFromPosition(m, i);
                    m += 2;

                    test[p] = tableLayoutPanel2.GetControlFromPosition(g, i);
                    g += 2;
                    p++;

                }
            }

            for (int i = 0; i < 6; i++)
            {
                if (test[i].Name == antwoord[i].Name)
                {
                    antwoord[i].ForeColor = Color.FromArgb(12, 255, 104);

                    a++;
                    if (a == 6)
                    {
                        Proficiat congrats = new Proficiat("dragNDrop");
                        congrats.Show();
                        this.Hide();
                    }

                }
                else
                {
                    antwoord[i].ForeColor = Color.FromArgb(255, 95, 0);
                }

            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Games games = new Games();
            games.Show();
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

    }
}
