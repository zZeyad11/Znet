namespace ZNetDesktopMonitor
{
    partial class MainProgranForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgranForm));
            this.ControlBoxPanel = new System.Windows.Forms.Panel();
            this.MinBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.SidePanelMinPanel = new System.Windows.Forms.Panel();
            this.SidePanelMinBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NumCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IPCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MacCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DownCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UploadCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScanProgressbar = new System.Windows.Forms.ProgressBar();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StopRedirectBtn = new System.Windows.Forms.Button();
            this.RedirectBtn = new System.Windows.Forms.Button();
            this.ScanBtn = new System.Windows.Forms.Button();
            this.TopPanelMinPanel = new System.Windows.Forms.Panel();
            this.TopPanelMinButton = new System.Windows.Forms.Button();
            this.ControlBoxPanel.SuspendLayout();
            this.SidePanel.SuspendLayout();
            this.SidePanelMinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TrayIconMenu.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TopPanelMinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlBoxPanel
            // 
            this.ControlBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(5)))), ((int)(((byte)(18)))));
            this.ControlBoxPanel.Controls.Add(this.MinBtn);
            this.ControlBoxPanel.Controls.Add(this.CloseBtn);
            resources.ApplyResources(this.ControlBoxPanel, "ControlBoxPanel");
            this.ControlBoxPanel.Name = "ControlBoxPanel";
            // 
            // MinBtn
            // 
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.MinBtn, "MinBtn");
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.CloseBtn, "CloseBtn");
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(5)))), ((int)(((byte)(18)))));
            this.SidePanel.Controls.Add(this.SidePanelMinPanel);
            this.SidePanel.Controls.Add(this.pictureBox1);
            this.SidePanel.Controls.Add(this.SettingBtn);
            resources.ApplyResources(this.SidePanel, "SidePanel");
            this.SidePanel.Name = "SidePanel";
            // 
            // SidePanelMinPanel
            // 
            this.SidePanelMinPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(18)))));
            this.SidePanelMinPanel.Controls.Add(this.SidePanelMinBtn);
            resources.ApplyResources(this.SidePanelMinPanel, "SidePanelMinPanel");
            this.SidePanelMinPanel.Name = "SidePanelMinPanel";
            // 
            // SidePanelMinBtn
            // 
            resources.ApplyResources(this.SidePanelMinBtn, "SidePanelMinBtn");
            this.SidePanelMinBtn.FlatAppearance.BorderSize = 0;
            this.SidePanelMinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SidePanelMinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SidePanelMinBtn.Name = "SidePanelMinBtn";
            this.SidePanelMinBtn.UseVisualStyleBackColor = true;
            this.SidePanelMinBtn.Click += new System.EventHandler(this.SidePanelMinBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZNetDesktopMonitor.Properties.Resources.ic_action_settings;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // SettingBtn
            // 
            this.SettingBtn.FlatAppearance.BorderSize = 0;
            this.SettingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SettingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.SettingBtn, "SettingBtn");
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.UseVisualStyleBackColor = true;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.TrayIconMenu;
            resources.ApplyResources(this.TrayIcon, "TrayIcon");
            // 
            // TrayIconMenu
            // 
            this.TrayIconMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TrayIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.TrayIconMenu.Name = "TrayIconMenu";
            resources.ApplyResources(this.TrayIconMenu, "TrayIconMenu");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainPanel.Controls.Add(this.listView1);
            this.MainPanel.Controls.Add(this.ScanProgressbar);
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.Name = "MainPanel";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumCol,
            this.NameCol,
            this.IPCol,
            this.MacCol,
            this.DownCol,
            this.UploadCol,
            this.StatusCol});
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // NumCol
            // 
            resources.ApplyResources(this.NumCol, "NumCol");
            // 
            // NameCol
            // 
            resources.ApplyResources(this.NameCol, "NameCol");
            // 
            // IPCol
            // 
            resources.ApplyResources(this.IPCol, "IPCol");
            // 
            // MacCol
            // 
            resources.ApplyResources(this.MacCol, "MacCol");
            // 
            // DownCol
            // 
            resources.ApplyResources(this.DownCol, "DownCol");
            // 
            // UploadCol
            // 
            resources.ApplyResources(this.UploadCol, "UploadCol");
            // 
            // StatusCol
            // 
            resources.ApplyResources(this.StatusCol, "StatusCol");
            // 
            // ScanProgressbar
            // 
            this.ScanProgressbar.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.ScanProgressbar, "ScanProgressbar");
            this.ScanProgressbar.MarqueeAnimationSpeed = 10;
            this.ScanProgressbar.Name = "ScanProgressbar";
            this.ScanProgressbar.Step = 1;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(5)))), ((int)(((byte)(18)))));
            this.TopPanel.Controls.Add(this.panel2);
            this.TopPanel.Controls.Add(this.TopPanelMinPanel);
            resources.ApplyResources(this.TopPanel, "TopPanel");
            this.TopPanel.Name = "TopPanel";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.StopRedirectBtn);
            this.panel2.Controls.Add(this.RedirectBtn);
            this.panel2.Controls.Add(this.ScanBtn);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // StopRedirectBtn
            // 
            resources.ApplyResources(this.StopRedirectBtn, "StopRedirectBtn");
            this.StopRedirectBtn.FlatAppearance.BorderSize = 0;
            this.StopRedirectBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.StopRedirectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StopRedirectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StopRedirectBtn.Name = "StopRedirectBtn";
            this.StopRedirectBtn.UseVisualStyleBackColor = true;
            this.StopRedirectBtn.Click += new System.EventHandler(this.StopRedirectBtn_Click);
            // 
            // RedirectBtn
            // 
            resources.ApplyResources(this.RedirectBtn, "RedirectBtn");
            this.RedirectBtn.FlatAppearance.BorderSize = 0;
            this.RedirectBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.RedirectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RedirectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RedirectBtn.Name = "RedirectBtn";
            this.RedirectBtn.UseVisualStyleBackColor = true;
            this.RedirectBtn.Click += new System.EventHandler(this.RedirectBtn_Click);
            // 
            // ScanBtn
            // 
            resources.ApplyResources(this.ScanBtn, "ScanBtn");
            this.ScanBtn.FlatAppearance.BorderSize = 0;
            this.ScanBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ScanBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ScanBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ScanBtn.Name = "ScanBtn";
            this.ScanBtn.UseVisualStyleBackColor = true;
            this.ScanBtn.Click += new System.EventHandler(this.ScanBtn_Click);
            // 
            // TopPanelMinPanel
            // 
            this.TopPanelMinPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(18)))));
            this.TopPanelMinPanel.Controls.Add(this.TopPanelMinButton);
            resources.ApplyResources(this.TopPanelMinPanel, "TopPanelMinPanel");
            this.TopPanelMinPanel.Name = "TopPanelMinPanel";
            // 
            // TopPanelMinButton
            // 
            resources.ApplyResources(this.TopPanelMinButton, "TopPanelMinButton");
            this.TopPanelMinButton.FlatAppearance.BorderSize = 0;
            this.TopPanelMinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.TopPanelMinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.TopPanelMinButton.Name = "TopPanelMinButton";
            this.TopPanelMinButton.UseCompatibleTextRendering = true;
            this.TopPanelMinButton.UseVisualStyleBackColor = true;
            this.TopPanelMinButton.Click += new System.EventHandler(this.TopPanelMinButton_Click);
            // 
            // MainProgranForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.ControlBoxPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainProgranForm";
            this.ControlBoxPanel.ResumeLayout(false);
            this.SidePanel.ResumeLayout(false);
            this.SidePanelMinPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TrayIconMenu.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.TopPanelMinPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlBoxPanel;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip TrayIconMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel SidePanelMinPanel;
        private System.Windows.Forms.Button SidePanelMinBtn;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ProgressBar ScanProgressbar;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel TopPanelMinPanel;
        private System.Windows.Forms.Button TopPanelMinButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button StopRedirectBtn;
        private System.Windows.Forms.Button RedirectBtn;
        private System.Windows.Forms.Button ScanBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NumCol;
        private System.Windows.Forms.ColumnHeader IPCol;
        private System.Windows.Forms.ColumnHeader MacCol;
        private System.Windows.Forms.ColumnHeader DownCol;
        private System.Windows.Forms.ColumnHeader UploadCol;
        private System.Windows.Forms.ColumnHeader StatusCol;
        private System.Windows.Forms.ColumnHeader NameCol;
    }
}

