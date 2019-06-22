//Author Name: Damien Bafile
//Creation Date: 13/06/2019
//Version Control: https://github.com/damien-bafile
//
using System;
using System.Windows.Forms;

namespace Calculator
{
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
            Application.Run(new FrmCalculator());
        }
    }
}