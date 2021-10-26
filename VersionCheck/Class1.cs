using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using Microsoft.Win32;
namespace VersionCheck
{
    class Class1
    {
        public static List<string> AppVersion()
        {
            List<string> aa = new List<string>();

            try
            {
                ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_Product");

                foreach (ManagementObject mo in mos.Get())
                {
                    if (mo["Name"] != null)
                        aa.Add(mo["Name"].ToString());
                }

            }
            catch (Exception ex)
            {

            }
            return aa;
        }

        public static string ProVersion(string appName)
        {
            string displayName;
            RegistryKey key;

            key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall");
            foreach (var keyName in key.GetSubKeyNames())
            {
                var subKey = key.OpenSubKey(keyName);
                displayName = subKey.GetValue("DisplayName") as string;
                if (appName.Equals(displayName, StringComparison.OrdinalIgnoreCase))
                    return subKey.GetValue("DisplayVersion").ToString();
            }
            return null;

        }
    }
}
