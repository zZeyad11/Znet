using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZNetDesktopMonitor.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            SetDragAndDrop();
        }
        private Thread GetDevices;
        private void GetCaptureDevices()
        {
            Action GetCaptureDevices = () => {
                RefreshBtn.Invoke(new Action(() => {  RefreshBtn.Enabled = false; }));
                NetworkInterfaceComboBox.Invoke(new Action(() => { NetworkInterfaceComboBox.Items.Clear(); }));
                var CaptureDevicesList = SharpPcap.CaptureDeviceList.Instance;
                CaptureDevicesList.ToList().ForEach(Item => { NetworkInterfaceComboBox.Invoke(new Action(() => { NetworkInterfaceComboBox.Items.Add(((SharpPcap.WinPcap.WinPcapDevice)Item).Interface.FriendlyName); })); });
                RefreshBtn.Invoke(new Action(() => { RefreshBtn.Enabled = true; }));
            };

            GetDevices = new Thread(new ThreadStart(GetCaptureDevices));
            GetDevices.Start();
            
        }

        #region FormMove
        private bool mouseDown;
        private Point lastLocation;
        private void SetDragAndDrop()
        {
            ControlBoxPanel.MouseDown += (sender, e) =>
            {
                mouseDown = true;
                lastLocation = e.Location;
            };
            ControlBoxPanel.MouseMove += (sender, e) =>
            {
                if (mouseDown)
                {
                    this.Location = new Point(
                        (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                    this.Update();
                }
            };
            ControlBoxPanel.MouseUp += (sender, e) =>
            { mouseDown = false; };
        }
        #endregion
        #region ControlBox
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NetworkInterfaceComboBox.Text))
            { 
            Classes.SettingsData data = new Classes.SettingsData();
            data.NetworkInterfaceDevice = NetworkInterfaceComboBox.Text;
            data.ScanTime = (byte)numericUpDown1.Value;
            data.LaunchAtStartup = StartWithWindowsCheckBox.Checked;
            Classes.SettingsSaverClass.SaveSettings(data);
            this.Close();
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            var Data = Classes.SettingsSaverClass.LoadSettings();
            if (Data != null)
            {
                if (Data.NetworkInterfaceDevice != null)
                {
                    NetworkInterfaceComboBox.Items.Add(Data.NetworkInterfaceDevice);
                    NetworkInterfaceComboBox.SelectedItem = Data.NetworkInterfaceDevice;
                }
                if (Data.ScanTime.CompareTo(0) != 0)
                {
                    numericUpDown1.Value = Data.ScanTime;
                }
                StartWithWindowsCheckBox.Checked = Data.LaunchAtStartup;
            }
            else 
            {
                GetCaptureDevices();
            }
        }

        private void ReffreshBtn_Click(object sender, EventArgs e)
        {
            GetCaptureDevices();

            var Data = Classes.SettingsSaverClass.LoadSettings();
            if (Data != null)
            {
                if (Data.NetworkInterfaceDevice != null)
                {
                    NetworkInterfaceComboBox.Text = Data.NetworkInterfaceDevice;
                    
                 
                }
            }
        }
    }
}
