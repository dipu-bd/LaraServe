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

            statusColumn.ImageGetter = delegate (object row) {
                Project project = (Project)row;
                switch(project.Status)
                {
                    case Status.Active:
                        return "active.png";
                    case Status.Inactive:
                        return "inactive.png";
                    case Status.Failing:
                        return "failing.png";
                    case Status.Unknown:
                    default:
                        return "unknown.png";
                }
            };
        }


        # region ---------- Public Functions ----------

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
                this.notifyIcon.ShowBalloonTip(1000);
                restoreToolStripMenuItem.Visible = true;
                minimizeToTrayToolStripMenuItem.Visible = false;
            }));
        }

        /// <summary>
        /// Loads project list.
        /// </summary>
        public void LoadProjects()
        {
            Projects samples = Projects.SampleData();
            projectListView.SetObjects(samples);
            nameColumn.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            urlColumn.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        /// <summary>
        /// Adds new project.
        /// </summary>
        public void AddNewProject()
        {

        }


        public void FilterBy(string text)
        {

        }

        #endregion

        #region ---------- Overrides ----------

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

        // Overrides OnLoad event.
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (Options.StartMinimized)
            {
                this.BeginInvoke(new MethodInvoker(this.Hide));
            }

            this.LoadProjects();
        }

        #endregion

        #region ---------- Form Events ----------

        // Changes into drag-move mode on this event.        
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

        private void cueTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Length >= 1)
            {
                searchButton.Enabled = true;
                searchButton.BackgroundImage = Properties.Resources.clear;
                this.FilterBy(searchTextBox.Text);
            }
            else
            {
                searchButton.BackgroundImage = Properties.Resources.glass;
                searchButton.Enabled = false;
            }
        }

        private void panel4_Enter(object sender, EventArgs e)
        {
            searchTextBox.Focus();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
        }

        private void closeToolButton_MouseEnter(object sender, EventArgs e)
        {
            closeToolButton.Image = Properties.Resources.close2;
        }

        private void closeToolButton_MouseLeave(object sender, EventArgs e)
        {
            closeToolButton.Image = Properties.Resources.close1;
        }

        private void settingsToolButton_MouseEnter(object sender, EventArgs e)
        {
            settingsToolButton.Image = Properties.Resources.cog2;
        }

        private void settingsToolButton_MouseLeave(object sender, EventArgs e)
        {
            settingsToolButton.Image = Properties.Resources.cog1;
        }

        private void projectListView_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            if (e.Column == nameColumn)
            {                
                e.SubItem.Font = new Font(e.SubItem.Font.FontFamily, 12F, FontStyle.Regular);
            }
            else if(e.Column == urlColumn)
            {
                e.SubItem.Font = new Font("Consolas", 11F, FontStyle.Regular);                
            }
        }

        #endregion
    }
}
