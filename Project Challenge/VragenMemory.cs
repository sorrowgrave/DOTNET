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

namespace DrivingPXL
{
    //Vragen voor memory game oproepen
    //Author: Lars Hoho
    //Date: 3/05/2014 14:45
    public partial class VragenMemory : Form
    {
        string doorgeven;
        int punten = 0;
        string selectedText ="";
        string hulp;
        int teller;
        string[] words = new string[4];
        MemoryGame currentGame = (MemoryGame)Application.OpenForms["MemoryGame"];
        public VragenMemory(string doorgeef, int teller)
        {
            InitializeComponent();
            doorgeven = doorgeef;
            this.teller = teller;
            nextButton.BackColor = Color.FromArgb(1, 100, 139);
            cancelButton.BackColor = Color.FromArgb(1, 100, 139);
        }

        public VragenMemory()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            hulp = words[1];

            if (selectedText.CompareTo(words[1].Trim()) == 0 && selectedText!="")
            {
                antwoordLabel.Text = "Goed zo";
                this.Refresh();
                System.Threading.Thread.Sleep(4000);
                currentGame.Enabled = true;
            }
            else 
            {
                antwoordLabel.Text = "fout het juiste antwoord is: \n" + words[1];
                this.Refresh();
                   System.Threading.Thread.Sleep(4000);
                currentGame.Close();

                MemoryGame newGame = new MemoryGame();
                newGame.Show();
                
            }

            if (teller == 8)
            {
                string request = "memory";
                Proficiat congrats = new Proficiat(request);
                congrats.Show();
                this.Hide();
            }
            this.Hide();
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Games games = new Games();
            games.Show();
            currentGame.Close();
            this.Close();
        }
        private void radioButton(object sender, EventArgs e)
        {
            var checkedButton = answersGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
            {
                selectedText = ((RadioButton)sender).Text;

            }
            else
            {
                 selectedText = "";

            } 
            
                
            
        }

        public int puntenDoorgeven()
        {
            return punten;
        }

        private void VragenMemory_Load(object sender, EventArgs e)
        {

            List<string> vraag = new List<string>() 
            { 
                "1", "2", "3"
            };


            string line = "";

            string[] nummer = new string[3];
            string path = "VragenMemory.txt";
            bool found = false;
            char[] seperator = { ';' };
            StreamReader inputstream = null;
            Random random = new Random();
            int randomNumber;

            inputstream = File.OpenText(((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\misc\\Vragenlijsten\\" + path)));

            line = inputstream.ReadLine();

            imageLabel.Image = Image.FromFile(((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\misc\\Verkeersborden\\" + doorgeven)));

            try
            {

                while (!found)
                {
                    words = line.Split(seperator);
                    if (words[0].Trim() == doorgeven)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            randomNumber = random.Next(vraag.Count);
                            nummer[i] = vraag[randomNumber];
                            vraag.RemoveAt(randomNumber);
                        }

                        antwoord1Radiobutton.Text = words[Convert.ToInt32(nummer[0])].Trim();
                        antwoord2Radiobutton.Text = words[Convert.ToInt32(nummer[1])].Trim();
                        antwoord3Radiobutton.Text = words[Convert.ToInt32(nummer[2])].Trim();

                        found = true;
                    }
                    else
                    {
                        line = inputstream.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Niets gevonden");
            }


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
