using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingPXL
{
    //Form voor het spelen van memorygame.
    //Date: 21/04/2014 18:46
    //Author: Lars Hoho
    public partial class MemoryGame : Form
    {
        string doorgeven = "";
        int teller2 = 0;
        int teller = 0;
        Label firstClicked = null;
        Label secondClicked = null;
        List<string> icons = new List<string>();
        String[] images = new String[16];
        Random random = new Random();
        VragenMemory punt = new VragenMemory();
        
        private void AssignIconsToSquares()
        {
            int counter=0;

            while (counter < 8)
            {
                int randomNum = random.Next(1, 194);
                if (!(icons.Contains(Convert.ToString(randomNum))))
                {
                    icons.Add(Convert.ToString(randomNum + ".jpeg"));
                    icons.Add(Convert.ToString(randomNum + ".jpeg"));
                    counter++;
                }
            }
                zetLabels();
        }

        public void zetLabels()
        {
            

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);

                    images[teller] = icons[randomNumber];
                    iconLabel.TabIndex = teller;
                    iconLabel.Name = images[teller];
                    iconLabel.Image = Image.FromFile((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\misc\\Verkeersborden\\" + images[teller]));
                    iconLabel.Image = Image.FromFile((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\misc\\Verkeersborden\\vraagteken.png"));
                    icons.RemoveAt(randomNumber);
                    teller++;
                }

            }
        }

        public MemoryGame()
        {
            InitializeComponent();
            
            AssignIconsToSquares();        
        }

        private void picture_clicked(object sender, EventArgs e)
        {

            Label clickedLabel = sender as Label;
            
            clickedLabel.Image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\misc\\Verkeersborden\\" + images[clickedLabel.TabIndex]);

            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                //Zorgt ervoor dat het label geupdate wordt!
                secondClicked.Refresh();

                if (firstClicked.Name == secondClicked.Name)
                {
                    teller2++;
                    doorgeven = firstClicked.Name;
                    firstClicked = null;
                    secondClicked = null;

                    VragenMemory vragenMemory = new VragenMemory(doorgeven, teller2);
                    vragenMemory.Show();
                    if (teller2 == 8)
                    {
                        teller2 = 0;
                        this.Close();
                    }
                    return;
                }
                verschillend();
            }        
        }

        private void verschillend()
        {
            System.Threading.Thread.Sleep(750);

            firstClicked.Image = Image.FromFile((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\misc\\Verkeersborden\\vraagteken.png"));
            secondClicked.Image = Image.FromFile((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DrivingPXL\\misc\\Verkeersborden\\vraagteken.png"));

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;

        }

        private void exitLabel_Click(object sender, EventArgs e)
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
