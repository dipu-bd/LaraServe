﻿namespace LaraServe
{
    partial class MainForm : System.Windows.Forms.Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runAtStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startMinimizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel5 = new System.Windows.Forms.Panel();
            this.projectListView = new BrightIdeasSoftware.ObjectListView();
            this.statusColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.nameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.urlColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new LaraServe.Components.CustomToolStrip();
            this.closeToolButton = new System.Windows.Forms.ToolStripButton();
            this.settingsToolButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.searchTextBox = new LaraServe.Components.CueTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.mainContextMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectListView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 60);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // mainContextMenu
            // 
            this.mainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProjectToolStripMenuItem,
            this.runAtStartupToolStripMenuItem,
            this.startMinimizedToolStripMenuItem,
            this.toolStripSeparator1,
            this.restoreToolStripMenuItem,
            this.minimizeToTrayToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainContextMenu.Name = "mainContextMenu";
            this.mainContextMenu.OwnerItem = this.settingsToolButton;
            this.mainContextMenu.Size = new System.Drawing.Size(167, 142);
            // 
            // addProjectToolStripMenuItem
            // 
            this.addProjectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addProjectToolStripMenuItem.Image")));
            this.addProjectToolStripMenuItem.Name = "addProjectToolStripMenuItem";
            this.addProjectToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addProjectToolStripMenuItem.Text = "Add Project";
            this.addProjectToolStripMenuItem.Click += new System.EventHandler(this.addProjectToolStripMenuItem_Click);
            // 
            // runAtStartupToolStripMenuItem
            // 
            this.runAtStartupToolStripMenuItem.CheckOnClick = true;
            this.runAtStartupToolStripMenuItem.Name = "runAtStartupToolStripMenuItem";
            this.runAtStartupToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.runAtStartupToolStripMenuItem.Text = "Run At Startup";
            this.runAtStartupToolStripMenuItem.CheckedChanged += new System.EventHandler(this.runAtStartupToolStripMenuItem_CheckedChanged);
            // 
            // startMinimizedToolStripMenuItem
            // 
            this.startMinimizedToolStripMenuItem.CheckOnClick = true;
            this.startMinimizedToolStripMenuItem.Name = "startMinimizedToolStripMenuItem";
            this.startMinimizedToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.startMinimizedToolStripMenuItem.Text = "Start Minimized";
            this.startMinimizedToolStripMenuItem.CheckedChanged += new System.EventHandler(this.startMinimizedToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restoreToolStripMenuItem.Image")));
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Visible = false;
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // minimizeToTrayToolStripMenuItem
            // 
            this.minimizeToTrayToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("minimizeToTrayToolStripMenuItem.Image")));
            this.minimizeToTrayToolStripMenuItem.Name = "minimizeToTrayToolStripMenuItem";
            this.minimizeToTrayToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.minimizeToTrayToolStripMenuItem.Text = "Minimize To Tray";
            this.minimizeToTrayToolStripMenuItem.Click += new System.EventHandler(this.minimizeToTrayToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.closeToolButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 60);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.searchButton);
            this.panel4.Controls.Add(this.searchTextBox);
            this.panel4.Location = new System.Drawing.Point(492, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 36);
            this.panel4.TabIndex = 3;
            this.panel4.TabStop = true;
            this.panel4.Click += new System.EventHandler(this.panel4_Enter);
            this.panel4.Enter += new System.EventHandler(this.panel4_Enter);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::LaraServe.Properties.Resources.glass;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchButton.Enabled = false;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(174, 0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(26, 36);
            this.searchButton.TabIndex = 2;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "The LaraServe is running in the background.";
            this.notifyIcon.ContextMenuStrip = this.mainContextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "LaraServe";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Location = new System.Drawing.Point(7, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(786, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Controls.Add(this.projectListView);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(7, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(786, 393);
            this.panel5.TabIndex = 3;
            // 
            // projectListView
            // 
            this.projectListView.AllColumns.Add(this.statusColumn);
            this.projectListView.AllColumns.Add(this.nameColumn);
            this.projectListView.AllColumns.Add(this.urlColumn);
            this.projectListView.BackColor = System.Drawing.Color.DarkSlateGray;
            this.projectListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projectListView.CellEditUseWholeCell = false;
            this.projectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.statusColumn,
            this.nameColumn,
            this.urlColumn});
            this.projectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.projectListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectListView.ForeColor = System.Drawing.Color.White;
            this.projectListView.FullRowSelect = true;
            this.projectListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.projectListView.Location = new System.Drawing.Point(0, 0);
            this.projectListView.Name = "projectListView";
            this.projectListView.SelectAllOnControlA = false;
            this.projectListView.ShowGroups = false;
            this.projectListView.ShowItemToolTips = true;
            this.projectListView.Size = new System.Drawing.Size(786, 393);
            this.projectListView.SmallImageList = this.imageList1;
            this.projectListView.TabIndex = 0;
            this.projectListView.UseCellFormatEvents = true;
            this.projectListView.UseCompatibleStateImageBehavior = false;
            this.projectListView.UseFilterIndicator = true;
            this.projectListView.UseFiltering = true;
            this.projectListView.UseHotItem = true;
            this.projectListView.UseHyperlinks = true;
            this.projectListView.UseTranslucentHotItem = true;
            this.projectListView.UseTranslucentSelection = true;
            this.projectListView.View = System.Windows.Forms.View.Details;
            this.projectListView.FormatCell += new System.EventHandler<BrightIdeasSoftware.FormatCellEventArgs>(this.projectListView_FormatCell);
            this.projectListView.IsHyperlink += new System.EventHandler<BrightIdeasSoftware.IsHyperlinkEventArgs>(this.projectListView_IsHyperlink);
            // 
            // statusColumn
            // 
            this.statusColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusColumn.Width = 32;
            // 
            // nameColumn
            // 
            this.nameColumn.AspectName = "Name";
            this.nameColumn.Hyperlink = true;
            this.nameColumn.Text = "Project Name";
            this.nameColumn.Width = 150;
            // 
            // urlColumn
            // 
            this.urlColumn.AspectName = "URL";
            this.urlColumn.FillsFreeSpace = true;
            this.urlColumn.Groupable = false;
            this.urlColumn.Hyperlink = true;
            this.urlColumn.Text = "Project URL";
            this.urlColumn.Width = 250;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "active.png");
            this.imageList1.Images.SetKeyName(1, "failing.png");
            this.imageList1.Images.SetKeyName(2, "inactive.png");
            this.imageList1.Images.SetKeyName(3, "unknown.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolButton,
            this.settingsToolButton});
            this.toolStrip1.Location = new System.Drawing.Point(695, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStrip1.Size = new System.Drawing.Size(91, 60);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // closeToolButton
            // 
            this.closeToolButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeToolButton.AutoSize = false;
            this.closeToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeToolButton.Image = global::LaraServe.Properties.Resources.close1;
            this.closeToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeToolButton.Name = "closeToolButton";
            this.closeToolButton.Size = new System.Drawing.Size(36, 42);
            this.closeToolButton.Text = "Close";
            this.closeToolButton.Click += new System.EventHandler(this.minimizeToTrayToolStripMenuItem_Click);
            this.closeToolButton.MouseEnter += new System.EventHandler(this.closeToolButton_MouseEnter);
            this.closeToolButton.MouseLeave += new System.EventHandler(this.closeToolButton_MouseLeave);
            // 
            // settingsToolButton
            // 
            this.settingsToolButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.settingsToolButton.AutoSize = false;
            this.settingsToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsToolButton.DropDown = this.mainContextMenu;
            this.settingsToolButton.Image = global::LaraServe.Properties.Resources.cog1;
            this.settingsToolButton.Name = "settingsToolButton";
            this.settingsToolButton.Size = new System.Drawing.Size(48, 42);
            this.settingsToolButton.Text = "Options";
            this.settingsToolButton.MouseEnter += new System.EventHandler(this.settingsToolButton_MouseEnter);
            this.settingsToolButton.MouseLeave += new System.EventHandler(this.settingsToolButton_MouseLeave);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Cue = "Search";
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(6, 8);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(163, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.cueTextBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(7, 0, 7, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaraServe";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.mainContextMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectListView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LaraServe.Components.CustomToolStrip toolStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton settingsToolButton;
        private System.Windows.Forms.ToolStripButton closeToolButton;
        private Components.CueTextBox searchTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private BrightIdeasSoftware.ObjectListView projectListView;
        private BrightIdeasSoftware.OLVColumn nameColumn;
        private BrightIdeasSoftware.OLVColumn urlColumn;
        private System.Windows.Forms.ContextMenuStrip mainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runAtStartupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startMinimizedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem minimizeToTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ImageList imageList1;
        private BrightIdeasSoftware.OLVColumn statusColumn;
    }
}

