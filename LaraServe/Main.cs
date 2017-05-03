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

namespace LaraServe
{
    public partial class Main : System.Windows.Forms.Form
    {
        public Main()
        {
            InitializeComponent();
            runAtStartupToolStripMenuItem.Checked = Options.RunAtStartup;
            startMinimizedToolStripMenuItem.Checked = Options.StartMinimized;
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

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            //this.Hide();
            this.Close();
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
