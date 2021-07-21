using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZNetDesktopMonitor
{
    public partial class MainProgranForm : Form
    {
        Classes.NetworkManger NetworkManger;
        
        public MainProgranForm()
        {
            InitializeComponent();
            SetDragAndDrop();       
        }

        private void NetworkManger_Update(object sender, Classes.UpdateEventArgs e)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                  if (!e.Insilence)
                    {
                        if (e.persent % 20 == 0)
                        {
                            SortListView();
                            
                        }
                        ScanProgressbar.Value = e.persent;
                    }
                }));
            }

          
        }

        private void NetworkManger_Finshed(object sender, Classes.FinshedEventArgs e)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                 ScanBtn.Enabled = true;
                if (NetworkManger.Network.Devices.Count > 0)
                {
                    RedirectBtn.Enabled = true;
                }
                }));
            }


           
        }

        private void  NetworkManger_FoundDevice(object sender ,Classes.NewDeviceFoundEventArgs e)
        {
            if (InvokeRequired) {

                this.Invoke(new Action(() =>
                    {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = (listView1.Items.Count + 1).ToString(); //Num
                    listViewItem.SubItems.Add(""); //Name
                    listViewItem.SubItems.Add(e.device.IP.ToString()); //IP Address
                    listViewItem.SubItems.Add(Classes.Tools.FormatMac(e.device.MacAddress,':'));  //Mac Address
                    listViewItem.SubItems.Add("");//Download Speed
                    listViewItem.SubItems.Add("");//Upload Speed
                    listViewItem.SubItems.Add("UP");//Connection Stauts
                        SortListView();
                    listView1.Items.Add(listViewItem);
                    Classes.Tools.GetMachineName(e.device, listView1);
                    }));
               }

            
        }

        #region ControlBox
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
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }
        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        } 
        #endregion
        #region DragBoxsAnimations

        private bool LeftPanelIsMoving = false;
        private async void SidePanelMinBtn_Click(object sender, EventArgs e)
        {
            Func<Control, Size, Size, float, Task> Scale = async (control, Start, End, DurationInSec) =>
            {
                Func<float, float, int, float> Lerp = (start, end, present) =>
                {
                    float OnePresent = (end - start) / 100;
                    float LerpResult = (present * OnePresent) + start;
                    return LerpResult;
                };
                for (int x = 1; x <= 100; x++)
                {

                    int Height = (int)Lerp(Start.Height, End.Height, x);

                    int Width = (int)Lerp(Start.Width, End.Width, x);




                    control.Size = new Size(Width, Height);

                    await Task.Delay((int)DurationInSec * 10);

                }
                LeftPanelIsMoving = false;
            };
            if (!LeftPanelIsMoving)
            {
                LeftPanelIsMoving = true;
                Size SidePanelDefaultSize = new Size(170, 488);
                int ScaleDurationInSeconds = 1;
                if (Math.Abs(SidePanel.Size.Width - SidePanelDefaultSize.Width) < 5)
                {

                    await Scale(SidePanel, SidePanel.Size, SidePanelMinBtn.Size, ScaleDurationInSeconds);


                }
                else if (Math.Abs(SidePanel.Size.Width - SidePanelMinBtn.Size.Width) < 5)
                {

                    await Scale(SidePanel, SidePanelMinBtn.Size, SidePanelDefaultSize, ScaleDurationInSeconds);


                }
            }
            LeftPanelIsMoving = false;
        }


        private bool TopPanelIsMoving = false;
        private async void TopPanelMinButton_Click(object sender, EventArgs e)
        {

            Func<Control, Size, Size, float, Task> Scale = async (control, Start, End, DurationInSec) =>
            {
                Func<float, float, int, float> Lerp = (start, end, present) =>
                {
                    float OnePresent = (end - start) / 100;
                    float LerpResult = (present * OnePresent) + start;
                    return LerpResult;
                };
                for (int x = 1; x <= 100; x++)
                {

                    int Height = (int)Lerp(Start.Height, End.Height, x);

                    int Width = (int)Lerp(Start.Width, End.Width, x);




                    control.Size = new Size(Width, Height);

                    await Task.Delay((int)DurationInSec * 10);

                }
                TopPanelIsMoving = false;
            };


            if (!TopPanelIsMoving)
            {
                TopPanelIsMoving = true;
                Size TopPanelDefaultSize = new Size(935, 50);
                int ScaleDurationInSeconds = 1;
                if (Math.Abs(TopPanel.Size.Height - TopPanelDefaultSize.Height) < Math.Abs(TopPanel.Size.Height - TopPanelMinButton.Size.Height)) //If Mixmized
                {

                    await Scale(TopPanel, TopPanel.Size, TopPanelMinButton.Size, ScaleDurationInSeconds);


                }
                else //If Minmized
                {

                    await Scale(TopPanel, TopPanelMinButton.Size, TopPanelDefaultSize, ScaleDurationInSeconds);


                }
            }
            TopPanelIsMoving = false;
        } 
        #endregion



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseApplication();
        }




        private void CloseApplication()
        {
            
            Application.Exit();
        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            if (!LeftPanelIsMoving && !TopPanelIsMoving)
            {
                ZNetDesktopMonitor.Forms.SettingsForm settings = new Forms.SettingsForm();
                settings.ShowDialog();
            }
        }

        private void ScanBtn_Click(object sender, EventArgs e)
        {
            var CurrentCaptureDevice = (SharpPcap.WinPcap.WinPcapDevice)(SharpPcap.CaptureDeviceList.Instance.Where(n => { return ((SharpPcap.WinPcap.WinPcapDevice)n).Interface.FriendlyName == Classes.SettingsSaverClass.LoadSettings().NetworkInterfaceDevice; }).ToList()[0]);
            #region Initlization
            if (NetworkManger == null)
            {
                NetworkManger = new Classes.NetworkManger(CurrentCaptureDevice);
                NetworkManger.Update += NetworkManger_Update;
                NetworkManger.FoundDevice += NetworkManger_FoundDevice;
                NetworkManger.Finshed += NetworkManger_Finshed;
            }
            if(NetworkManger.CaptureDevice != CurrentCaptureDevice)
            {
                listView1.Items.Clear();
                ScanProgressbar.Value = 0;
                NetworkManger.Dispose();
                NetworkManger = new Classes.NetworkManger(CurrentCaptureDevice);
                NetworkManger.Update += NetworkManger_Update;
                NetworkManger.FoundDevice += NetworkManger_FoundDevice;
                NetworkManger.Finshed += NetworkManger_Finshed;
            }
            #endregion
            NetworkManger.StartNetworkScaning(false);
            ScanBtn.Enabled = false;
        }



        void SortListView() 
        {
            if (listView1.Items.Count > 0)
            {
                

                var SortedListViewItems = (from Item in listView1.Items.Cast<ListViewItem>() where Item != null orderby (int.Parse(Item.SubItems[listView1.Columns.IndexOf(listView1.Columns.OfType<ColumnHeader>().ToList().Where(n => n.Text == "IP").ToList()[0])].Text.Split('.')[3])) select Item).ToList();
                SortedListViewItems.ForEach(n => n.SubItems[0].Text = (n.Index + 1).ToString());
                listView1.Items.Clear();
                SortedListViewItems.ForEach(Item => listView1.Items.Add(Item));
            }
        }

        private void RedirectBtn_Click(object sender, EventArgs e)
        {
            RedirectBtn.Enabled = false;
            StopRedirectBtn.Enabled = true;
            NetworkManger.RedirectPackets();
        }

        private void StopRedirectBtn_Click(object sender, EventArgs e)
        {
            StopRedirectBtn.Enabled = false;
            RedirectBtn.Enabled = true;
        }
    }
}
