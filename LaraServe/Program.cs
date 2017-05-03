using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaraServe.Helper;

namespace LaraServe
{
    static class Program
    {
        static MainForm mainForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PreTasks();

            mainForm = new MainForm();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainForm);

            PostTasks();
        }

        private static void PreTasks()
        {
            // initialize the database
            Database.Initiate();

            // set run at startup on first run
            if (Utils.IsFirstRun()) {
                Options.RunAtStartup = true;
            }

            // save last run timestamp
            Options.LastRun = DateTime.Now;

        }

        private static void PostTasks()
        {
            if (Options.StartMinimized)
            {
                mainForm.Hide();
            }
        }
    }
}
