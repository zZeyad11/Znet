using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpPcap;
using SharpPcap.WinPcap;
using SharpPcap.AirPcap;

namespace ZNetDesktopMonitor.Classes
{
    [Serializable]
    public class SettingsData
    {
        public string NetworkInterfaceDevice;
        public byte ScanTime;
        public bool LaunchAtStartup;

    }
}
