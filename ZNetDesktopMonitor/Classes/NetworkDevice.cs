using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ZNetDesktopMonitor.Classes
{
    [Serializable]
    internal class NetworkDevice
    {
        //Ids
        public string Name;
        public IPAddress IP;
        public PhysicalAddress MacAddress;
        public string MacVendor;

        //Prefrences
        ///Public Ones
        public double MaxDownloadSpeedInKB;
        public double MaxUploadSpeedInKB;
        public bool BlockInternet;
        public float MaxDownloadCapacityInMb;
        public float MaxDownloadCapcityPerDayInMB;
        //Private Ones
        
        //Helpers
        public bool IsLocalPc;
        public bool IsRouter;
    }
}
