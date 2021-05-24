using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System__BFM1_
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// 
        /// First Submission: Benjamin Hoagland for Software Development - Software I – C# – C968
        /// submitted on 2021-05-22 at 11:00 
        /// </summary>
        public static MainScreen mainScreen;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainScreen = new MainScreen();
            Application.Run(mainScreen);

            
        }
    }
}
