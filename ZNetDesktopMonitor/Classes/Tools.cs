using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZNetDesktopMonitor.Classes
{
    class Tools
    {
        /// <summary>
   /// Get Brand"Vendor" Of Device from Mac Address
   /// </summary>
   /// <param name="MacAddress">Mac Address Of The Target</param>
   /// <returns></returns>
        public static string GetMacVendor(System.Net.NetworkInformation.PhysicalAddress MacAddress)
        {
            var macAddressInString = FormatMac(MacAddress,':');
            string Vander = null;
            Stopwatch stopwatch = new Stopwatch();


            Action GetName = new Action(async () =>
            {
                try
                {
                    var uri = new Uri("http://api.macvendors.com/" +macAddressInString);
                    using (var wc = new HttpClient())
                    {
                        Vander = await wc.GetStringAsync(uri);
                    }
                }
                catch {
                    return;
                }
            });
            stopwatch.Start();
            GetName();
            if (stopwatch.ElapsedMilliseconds > 1000)
            {
                stopwatch.Stop();
                GetName = null;
                return null;
            }
            return Vander;
        }


        /// <summary>
        /// Convert Mac To Standered Form For The User
        /// </summary>
        /// <param name="phyicalAddress">Mac Address</param>
        /// <param name="Symbol">Character That Will Seaperate Between 2 Letters</param>
        /// <returns></returns>
        public static string FormatMac(System.Net.NetworkInformation.PhysicalAddress phyicalAddress, char Symbol)
        {
           return string.Join(Symbol.ToString(), (from z in phyicalAddress.GetAddressBytes() select z.ToString("X2")).ToArray());
        }


        public async static Task GetMachineName(NetworkDevice device,ListView LV) 
        {
            try
            {
                if (device.IsRouter)
                {
                    LV.Items.OfType<ListViewItem>().ToList().ForEach(n =>
                    {
                        if (n.SubItems[LV.Columns.IndexOf(LV.Columns.OfType<ColumnHeader>().ToList().Where(col => col.Text == "IP").ToList()[0])].Text == device.IP.ToString())
                        {
                            if (string.IsNullOrEmpty(device.Name))
                            {
                                n.SubItems[1].Text = "Router";
                            }
                        }
                    });
                    return;
                }


                var Result = await Dns.GetHostEntryAsync(device.IP);
                if (string.IsNullOrEmpty(Result.HostName) || string.IsNullOrWhiteSpace(Result.HostName)) return;
                LV.Items.OfType<ListViewItem>().ToList().ForEach(n => 
                { 
                    if (n.SubItems[LV.Columns.IndexOf(LV.Columns.OfType<ColumnHeader>().ToList().Where(col => col.Text == "IP").ToList()[0])].Text == device.IP.ToString()) 
                    {
                        //Get Name From Saved Data And See If It's Empty
                        if (string.IsNullOrEmpty(device.Name))
                        {  
                            //Set Name To Data
                            device.Name = Result.HostName;

                            //See If Its Router Or Local Pc
                            if (device.IsLocalPc)
                            {
                                if (device.IsLocalPc)
                                {
                                    n.SubItems[1].Text = device.Name + "\n (Local Pc)";
                                }
                            }
                            //If Not Router or Local Pc
                            else 
                            {
                                n.SubItems[1].Text = device.Name;
                            }
                        }
                        //If Name From Data Isn't Empty
                        else 
                        {
                            if (device.Name == Result.HostName)
                            {
                                if (device.IsLocalPc)
                                {
                                    n.SubItems[1].Text = device.Name +"\n (Local Pc)";
                                }
                                else
                                { n.SubItems[1].Text = device.Name; }
                            }
                            else
                            {
                                if (!device.IsLocalPc)
                                {
                                    n.SubItems[1].Text = device.Name + " \"" + Result.HostName + "\"";
                                }
                                else { n.SubItems[1].Text = device.Name + " \"" + Result.HostName + "\"" + "\n (Local Pc)";  }
                            }
                        }
                    } 
                });
               
            }
            catch {
               
            
            }

        }
    }
}
