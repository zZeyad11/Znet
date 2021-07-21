namespace ZNetDesktopMonitor.Forms
{
    partial class SettingsForm
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
            this.ControlBoxPanel = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SwitchPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GernalBtn = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.NetworkInterfaceComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NetworkInterfaceLabel = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.StartWithWindowsCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ControlBoxPanel.SuspendLayout();
            this.SwitchPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlBoxPanel
            // 
            this.ControlBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(5)))), ((int)(((byte)(18)))));
            this.ControlBoxPanel.Controls.Add(this.CloseBtn);
            this.ControlBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlBoxPanel.Name = "ControlBoxPanel";
            this.ControlBoxPanel.Size = new System.Drawing.Size(496, 47);
            this.ControlBoxPanel.TabIndex = 1;
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Bold);
            this.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CloseBtn.Location = new System.Drawing.Point(430, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(55, 36);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SwitchPanel
            // 
            this.SwitchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(5)))), ((int)(((byte)(18)))));
            this.SwitchPanel.Controls.Add(this.panel2);
            this.SwitchPanel.Controls.Add(this.GernalBtn);
            this.SwitchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SwitchPanel.Location = new System.Drawing.Point(0, 47);
            this.SwitchPanel.Name = "SwitchPanel";
            this.SwitchPanel.Size = new System.Drawing.Size(496, 51);
            this.SwitchPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.panel2.Location = new System.Drawing.Point(3, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 5);
            this.panel2.TabIndex = 1;
            // 
            // GernalBtn
            // 
            this.GernalBtn.FlatAppearance.BorderSize = 0;
            this.GernalBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GernalBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GernalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GernalBtn.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GernalBtn.Location = new System.Drawing.Point(0, 3);
            this.GernalBtn.Name = "GernalBtn";
            this.GernalBtn.Size = new System.Drawing.Size(134, 52);
            this.GernalBtn.TabIndex = 0;
            this.GernalBtn.Text = "Gernal";
            this.GernalBtn.UseVisualStyleBackColor = true;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.StartWithWindowsCheckBox);
            this.MainPanel.Controls.Add(this.numericUpDown1);
            this.MainPanel.Controls.Add(this.RefreshBtn);
            this.MainPanel.Controls.Add(this.NetworkInterfaceComboBox);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.NetworkInterfaceLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 98);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(496, 393);
            this.MainPanel.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(211, 116);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(172, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.AutoSize = true;
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RefreshBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(389, 67);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(90, 32);
            this.RefreshBtn.TabIndex = 2;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.ReffreshBtn_Click);
            // 
            // NetworkInterfaceComboBox
            // 
            this.NetworkInterfaceComboBox.FormattingEnabled = true;
            this.NetworkInterfaceComboBox.Location = new System.Drawing.Point(211, 70);
            this.NetworkInterfaceComboBox.Name = "NetworkInterfaceComboBox";
            this.NetworkInterfaceComboBox.Size = new System.Drawing.Size(172, 24);
            this.NetworkInterfaceComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max Scan Time:";
            // 
            // NetworkInterfaceLabel
            // 
            this.NetworkInterfaceLabel.AutoSize = true;
            this.NetworkInterfaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkInterfaceLabel.Location = new System.Drawing.Point(3, 69);
            this.NetworkInterfaceLabel.Name = "NetworkInterfaceLabel";
            this.NetworkInterfaceLabel.Size = new System.Drawing.Size(187, 25);
            this.NetworkInterfaceLabel.TabIndex = 0;
            this.NetworkInterfaceLabel.Text = "Network Interface:";
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.SaveBtn);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 440);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(496, 51);
            this.BottomPanel.TabIndex = 4;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SaveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(0, 0);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(496, 51);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // StartWithWindowsCheckBox
            // 
            this.StartWithWindowsCheckBox.AutoSize = true;
            this.StartWithWindowsCheckBox.Location = new System.Drawing.Point(297, 40);
            this.StartWithWindowsCheckBox.Name = "StartWithWindowsCheckBox";
            this.StartWithWindowsCheckBox.Size = new System.Drawing.Size(18, 17);
            this.StartWithWindowsCheckBox.TabIndex = 4;
            this.StartWithWindowsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Launch at startup :";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(496, 491);
            this.ControlBox = false;
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SwitchPanel);
            this.Controls.Add(this.ControlBoxPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ControlBoxPanel.ResumeLayout(false);
            this.SwitchPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlBoxPanel;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Panel SwitchPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button GernalBtn;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ComboBox NetworkInterfaceComboBox;
        private System.Windows.Forms.Label NetworkInterfaceLabel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox StartWithWindowsCheckBox;
        private System.Windows.Forms.Label label3;
    }
}