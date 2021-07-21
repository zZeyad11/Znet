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
    internal class Network
    {
        public string SSID;
        public PhysicalAddress RouterMacAddress;
        public List<NetworkDevice> Devices { get; private set; }


        public Network() 
        {
            Devices = new List<NetworkDevice>();
        }
        /// <summary>
        /// Add Device To Network
        /// </summary>
        /// <param name="Device">Device That Will Be Added</param>
        public void AddDevice(NetworkDevice Device) 
        {
            if (Device == null) return;

            Devices.Add(Device);
        }
        /// <summary>
        /// Remove Device From Network
        /// </summary>
        /// <param name="Device">Device That Will Be Removed</param>
        public void Remove(NetworkDevice Device)
        {
            if (Device == null) return;

            Devices.Remove(Device);
        }
        /// <summary>
        /// Remove Device From Network
        /// </summary>
        /// <param name="Index">Index of The Device That Will Be Removed</param>
        public void Remove(int Index)
        { 
            Devices.RemoveAt(Index);
        }


        /// <summary>
        /// Get The Router Information As NetworkDevice Instance
        /// </summary>
        /// <returns>Returns Instance Of Router</returns>
        public NetworkDevice GetRouter() 
        {
            if (Devices == null) return null;
            else
            {
                return Devices.Where(n => n.IsRouter == true).ToList()[0];
            }
        }
        /// <summary>
        /// Get The Local Pc Information As NetworkDevice Instance
        /// </summary>
        /// <returns>Returns Local Pc Instance</returns>
        public NetworkDevice GetLocalPC()
        {
            if (Devices == null) return null;
            else
            {
                return Devices.Where(n => n.IsLocalPc == true).ToList()[0];
            }
        }

        /// <summary>
        /// Get Network Device From IP
        /// </summary>
        /// <param name="Ip">IP Of The Device</param>
        /// <returns>Network Device</returns>
        public NetworkDevice GetNetworkDeviceFromIP(IPAddress Ip) 
        {
            if (Ip != null && Devices != null)
            {
                return Devices.Where(n => n.IP.ToString() == Ip.ToString()).ToList()[0];
            }
            else
                return null;
        }
        /// <summary>
        /// Get Network Device From Mac Address
        /// </summary>
        /// <param name="MacAddress"></param>
        /// <returns>Netwrok Device</returns>
        public NetworkDevice GetNetworkDeviceFromMac(PhysicalAddress MacAddress)
        {
            if (MacAddress != null && Devices != null)
            {
                return Devices.Where(n => Tools.FormatMac(n.MacAddress,':') == Tools.FormatMac(MacAddress,':')).ToList()[0];
            }
            else
                return null;
        }
    }
}
