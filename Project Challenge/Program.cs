using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingPXL
{  
    //Programma Driving PXL.
    //Date: 15/04/2014 23:10 
    //Authors: Kenny Vanrusselt, Lars Hoho, Olivier Quaethoven, Niels Carmans
    static class Program 
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Menu());
            Application.Run(new Login());
            //Application.Run(new Register());
            //Application.Run(new Validation());
            //Application.Run(new DragAndDrop());
            //Application.Run(new Proficiat());
            //Application.Run(new Games());
        }
    }
}
