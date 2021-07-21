using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ZNetDesktopMonitor.Classes
{
    public class SettingsSaverClass
    {

        public static void SaveSettings(SettingsData data) 
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                binaryFormatter.Serialize(ms, data);
                var bytearray = ms.ToArray();
                File.WriteAllBytes("Data.inf",bytearray);
            }
           
        
        }

        public static SettingsData LoadSettings()
        {
            try
            {
                using (var memStream = new MemoryStream())
                {
                    var binForm = new BinaryFormatter();
                    var array = File.ReadAllBytes("Data.inf");
                    memStream.Write(array, 0, array.Length);
                    memStream.Seek(0, SeekOrigin.Begin);
                    var obj = binForm.Deserialize(memStream);
                    return (SettingsData)obj;
                }
            }
            catch { return null; }
        }
    }
}
