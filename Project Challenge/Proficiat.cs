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
    //Keuze om drag and drop te hervatten of om terug naar het hoofdmenu te gaan
    //Author: Olivier Quaethoven
    //Date: 7/05/2014 14/20
    public partial class Proficiat : Form
    {
        string loadRequest;
        public Proficiat()
        {
            InitializeComponent();
            proficiatLabel.Text = "Proficiat alle antwoorden waren correct,  wat wenst u nu te doen?";
            playLabel.BackColor = Color.FromArgb(1, 100, 139);
            menuLabel.BackColor = Color.FromArgb(1, 100, 139);
        }

        public Proficiat(string request)
        {
            InitializeComponent();
            loadRequest = request;
            proficiatLabel.Text = "Proficiat u heeft de memory game uitgespeeld";

            playLabel.BackColor = Color.FromArgb(1, 100, 139);
            menuLabel.BackColor = Color.FromArgb(1, 100, 139);
        }

        private void menuLabel_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void playLabel_Click(object sender, EventArgs e)
        {
            if(loadRequest.Equals("memory")){
                MemoryGame memoryGame = new MemoryGame();
                memoryGame.Show();
                this.Hide();
            }else{
                DragAndDrop drag = new DragAndDrop();
                drag.Show();
                this.Hide();
            }
            
        }

        private void playLabel_MouseLeave(object sender, EventArgs e)
        {
            playLabel.BackColor = Color.FromArgb(1, 100, 139);
        }

        private void playLabel_MouseHover(object sender, EventArgs e)
        {
            playLabel.BackColor = Color.FromArgb(11, 134, 168);
        }
        private void menuLabel_MouseLeave(object sender, EventArgs e)
        {
            menuLabel.BackColor = Color.FromArgb(1, 100, 139);
        }

        private void menuLabel_MouseHover(object sender, EventArgs e)
        {
            menuLabel.BackColor = Color.FromArgb(11, 134, 168);
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
