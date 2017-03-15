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
    //Keuzeform waar je kan kiezen tussen drag en drop of memorygame.
    //Date: 04/05/2014 17:25
    //Author: Kenny Vanrusselt
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
        }

        private void returnLabel_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void dragNDropButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DragAndDrop draganddrop = new DragAndDrop();
            draganddrop.Show();
            
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

        private void memoryClick(object sender, EventArgs e)
        {
            MemoryGame memory = new MemoryGame();
            memory.Show();
            this.Hide();
            
        }


    }
}
