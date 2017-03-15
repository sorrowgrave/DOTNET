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
    //Form waar de resultaten worden getoond.
    //Author: Kenny Vanrusselt
    //Date: 10/05/2014 14:25
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
            userLabel.Text = "Behaalde resultaten van: " + Variables.name + " " + Variables.surname;
            readScores();
            resultatenListBox.BackColor = Color.FromArgb(1, 100, 139);
            returnLabel.BackColor = Color.FromArgb(1, 100, 139);
        }

        private void returnLabel_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void returnLabel_MouseHover(object sender, EventArgs e)
        {
            returnLabel.BackColor = Color.FromArgb(11, 134, 168);
        }

        private void returnLabel_MouseLeave(object sender, EventArgs e)
        {
            returnLabel.BackColor = Color.FromArgb(1, 100, 139);
        }

        
        public void readScores()
        {
            string[] data = new string[1];
            string comment;
            int i = 1;
            string path = Variables.path + "\\scores.txt";
            if (File.Exists(path) && new FileInfo(path).Length != 0)
            {
                
                using (StreamReader r = new StreamReader(@path))
                {
                    while (!r.EndOfStream)
                    {
                        string record = r.ReadLine();
                        data = record.Split(';');

                        if (Convert.ToInt32(data[1]) >= 41)
                            comment = "Proficiat! U bent geslaagd.";
                        else
                            comment = "Volgende keer beter!";

                        resultatenListBox.Items.Add(i + ".\t" + data[0] + "\t" + data[1].PadLeft(5 - data[1].Length) + "/50" + "\t\t" + comment);
                        i++;
                    }

                }

            }
            else
                resultatenListBox.Items.Add("\t\t         Er zijn nog geen resultaten beschikbaar");
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
