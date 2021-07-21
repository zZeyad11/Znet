using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using SharpPcap;
using SharpPcap.WinPcap;
using System.Net.NetworkInformation;
using System.Net;
using PacketDotNet;
using System.Diagnostics;

namespace ZNetDesktopMonitor.Classes
{
    internal class NetworkManger : IDisposable
    {

       
        private Dictionary<IPAddress, PhysicalAddress> DevicesFound;


        public WinPcapDevice CaptureDevice { get; private set; }
        public Network Network;
        public bool IsScaning { get; private set; }

        public event EventHandler<NewDeviceFoundEventArgs> FoundDevice;
        public event EventHandler<UpdateEventArgs> Update;
        public event EventHandler<FinshedEventArgs> Finshed;

        private Thread SendArpPacketsThread;
        private Thread ReciveArpPacketsThread;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="CaptureDevice">NetworkInterface That Packets Will Managed Through</param>
        /// 

        public NetworkManger(WinPcapDevice CaptureDevice)
        {
            if (CaptureDevice != null)
            {
                this.CaptureDevice = CaptureDevice;
                DevicesFound = new Dictionary<IPAddress, PhysicalAddress>();
                Network = new Network();
            }
            else return;
        }

        ~NetworkManger() 
        {
            Dispose();
        }

        private void ScanNetworkForNetDevices(bool InSilence)
        {
            
            if (IsScaning) return; 
            CaptureDevice.Open(DeviceMode.Promiscuous, 1000);
         
            #region Methods
            Func<IPAddress, string> GetRootIp = (IP) => 
            {
                string ipaddressstring = IP.ToString();
                return ipaddressstring.Substring(0, ipaddressstring.LastIndexOf(".") + 1);

            };
            Func<IPAddress, IPAddress, bool> areCompatibleIPs = (ip1, ip2) =>
              { return (GetRootIp(ip1) == GetRootIp(ip2)) ? true : false; };
            #endregion
            
            IsScaning = true;

            Action ScanAction = () => {


              
                
                Action SendArpPackets = () =>
                {
                    while (CaptureDevice != null && IsScaning)
                    {
                        for (int ipindex = 1; ipindex <= 255; ipindex++)
                        {
                            try
                            {
                                ARPPacket arprequestpacket = new ARPPacket(ARPOperation.Request, PhysicalAddress.Parse("00-00-00-00-00-00"), IPAddress.Parse(GetRootIp(CaptureDevice.Addresses[1].Addr.ipAddress) + ipindex), CaptureDevice.MacAddress, CaptureDevice.Addresses[1].Addr.ipAddress);
                                EthernetPacket ethernetpacket = new EthernetPacket(CaptureDevice.MacAddress, PhysicalAddress.Parse("FF-FF-FF-FF-FF-FF"), EthernetPacketType.Arp);
                                ethernetpacket.PayloadPacket = arprequestpacket;
                                CaptureDevice.SendPacket(ethernetpacket);
                            }
                            catch { continue; }
                        }
                    }
                };
                Action ReciveArpPackets = () => {
                    
                    RawCapture rawcapture = null;
                    CaptureDevice.Filter = "arp";
                    
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();


                    while ((rawcapture = CaptureDevice.GetNextPacket()) != null && stopwatch.ElapsedMilliseconds <= (SettingsSaverClass.LoadSettings().ScanTime * 1000))
                    {
                        if (!InSilence)
                        {
                            int percentageprogress = (int)((float)stopwatch.ElapsedMilliseconds / (SettingsSaverClass.LoadSettings().ScanTime * 1000) * 100);
                            Update?.Invoke(this,new UpdateEventArgs() { Insilence = InSilence , persent = percentageprogress});
                        }
                        Packet packet = Packet.ParsePacket(rawcapture.LinkLayerType, rawcapture.Data);
                        ARPPacket arppacket = (ARPPacket)packet.Extract(typeof(ARPPacket));
                        if (!DevicesFound.ContainsKey(arppacket.SenderProtocolAddress) && arppacket.SenderProtocolAddress.ToString() != "0.0.0.0" && areCompatibleIPs(arppacket.SenderProtocolAddress, CaptureDevice.Addresses[1].Addr.ipAddress))
                        {

                            DevicesFound.Add(arppacket.SenderProtocolAddress, arppacket.SenderHardwareAddress);
                            NetworkDevice newNetworkDevice = new NetworkDevice();
                            newNetworkDevice.IP = arppacket.SenderProtocolAddress;
                            newNetworkDevice.MacAddress = arppacket.SenderHardwareAddress;
                            newNetworkDevice.MacVendor = Tools.GetMacVendor(arppacket.SenderHardwareAddress);

                            if (newNetworkDevice.IP.ToString() == CaptureDevice.Interface.GatewayAddress.ToString())
                            {
                                newNetworkDevice.IsRouter = true;
                                Network.RouterMacAddress = newNetworkDevice.MacAddress;
                            }

                            else if (newNetworkDevice.IP.ToString() == CaptureDevice.Addresses[1].Addr.ipAddress.ToString())
                                newNetworkDevice.IsLocalPc = true;


                            Network.AddDevice(newNetworkDevice);

                            FoundDevice?.Invoke(this,new NewDeviceFoundEventArgs() { device = Network.Devices.Where(d => d.IP == newNetworkDevice.IP).ToList()[0]});
                            
                           
                        }
                      
                    }
                    IsScaning = false;
                    stopwatch.Stop();
                    Update?.Invoke(this,new UpdateEventArgs() { Insilence = InSilence ,persent = 100});
                    Finshed?.Invoke(this,new FinshedEventArgs() { WasItInSilence = InSilence});
                };



                if (SendArpPacketsThread!=null && SendArpPacketsThread.IsAlive) { SendArpPacketsThread.Abort(); }
                SendArpPacketsThread = new Thread(new ThreadStart(SendArpPackets)) { IsBackground = true };

                if (ReciveArpPacketsThread != null && ReciveArpPacketsThread.IsAlive) { ReciveArpPacketsThread.Abort(); }
                ReciveArpPacketsThread =new Thread(new ThreadStart(ReciveArpPackets)) { IsBackground = true };

                SendArpPacketsThread.Start();
                ReciveArpPacketsThread.Start();

            };

            ScanAction();
        }

        public void StartNetworkScaning(bool InSilence) 
        {
            ScanNetworkForNetDevices(InSilence);
        }
        public void StopNetworkScaning()
        {
            if (SendArpPacketsThread != null)
            {
                SendArpPacketsThread.Abort();
            }
            if (ReciveArpPacketsThread != null)
            {
                ReciveArpPacketsThread.Abort();
            }

            IsScaning = false;

        }


        public void RedirectPackets() 
        {

            SharpPcap.LibPcap.PcapDevice pcapDevice = CaptureDevice;
            pcapDevice.Open(SharpPcap.DeviceMode.Promiscuous, 1000);
            pcapDevice.Filter = "ip and tcp";
            pcapDevice.OnPacketArrival += (Sender, Packet) =>
            {
                var packet = PacketDotNet.Packet.ParsePacket(Packet.Packet.LinkLayerType, Packet.Packet.Data);
                
                Console.WriteLine(Packet.Packet.Data);
            };
            pcapDevice.StartCapture();
           

        
        }

        public void Dispose()
        {
            if (SendArpPacketsThread != null)
            {
                SendArpPacketsThread.Abort();
            }
            if (ReciveArpPacketsThread != null) 
            {
                ReciveArpPacketsThread.Abort();
            }
            SendArpPacketsThread = null;
            ReciveArpPacketsThread = null;
            IsScaning = false;
            Network = null;
            Update = null;
            FoundDevice = null;
            Finshed = null;
            if (CaptureDevice != null)
            {
                CaptureDevice.StopCapture();
                CaptureDevice.Close();
                CaptureDevice = null;
            }
            
            DevicesFound.Clear();
            DevicesFound = null;
        }
    }



    internal class NewDeviceFoundEventArgs : EventArgs
    {
        public NetworkDevice device;
    }
    internal class UpdateEventArgs : EventArgs
    {
        public int persent;
        public  bool Insilence;

    }
    internal class FinshedEventArgs : EventArgs
    {
        public bool WasItInSilence;

    }
}
