using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaraServe.Helper;
using LaraServe.Models;

namespace LaraServe
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();

            runAtStartupToolStripMenuItem.Checked = Options.RunAtStartup;
            startMinimizedToolStripMenuItem.Checked = Options.StartMinimized;
        }

        /// <summary>
        /// Restors the window to the previous position.
        /// </summary>
        public void Restore()
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                this.Show();
                restoreToolStripMenuItem.Visible = false;
                minimizeToTrayToolStripMenuItem.Visible = true;
            }));
        }

        /// <summary>
        /// Minimizes the window to the tray.
        /// </summary>
        public void MinimizeToTray()
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                this.Hide();
                this.notifyIcon.ShowBalloonTip(2000);
                restoreToolStripMenuItem.Visible = true;
                minimizeToTrayToolStripMenuItem.Visible = false;
            }));
        }

        /// <summary>
        /// Adds new project.
        /// </summary>
        public void AddNewProject()
        {

        }

        /// <summary>
        /// Loads project list.
        /// </summary>
        public void LoadProjects()
        {
            Projects samples = Projects.SampleData();
            projectListView.SetObjects(samples);
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (Options.StartMinimized)
            {
                this.BeginInvoke(new MethodInvoker(this.Hide));
            }

            this.LoadProjects();
        }

        /// <summary>
        /// Drops shadow outside of the current form.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        /// <summary>
        /// Changes into drag-move mode on this event.
        /// </summary>
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WinAPI.ReleaseCapture();
                WinAPI.SendMessage(Handle, WinAPI.WM_NCLBUTTONDOWN, WinAPI.HT_CAPTION, 0);
            }
        }

        private void closeToolButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Restore();
        }

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Restore();
            this.AddNewProject();
        }

        private void runAtStartupToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Options.RunAtStartup = ((ToolStripMenuItem)sender).Checked;
        }

        private void startMinimizedToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Options.StartMinimized = ((ToolStripMenuItem)sender).Checked;
        }

        private void minimizeToTrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MinimizeToTray();
        }

        private void cueTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // filter or search by text
            }
        }



    }
}
