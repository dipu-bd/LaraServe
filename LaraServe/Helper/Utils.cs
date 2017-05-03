using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace LaraServe.Helper
{
    public static class Utils
    {
        /// <summary>
        /// Sets whether the application to run at startup.
        /// </summary>
        /// <param name="value"></param>
        public static void SetStartup(bool value)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (value)
            {
                key.SetValue(Application.ProductName, Application.ExecutablePath.ToString());
            }
            else
            {
                key.DeleteValue(Application.ProductName, false);
            }
        }

        /// <summary>
        /// Gets whether the application is set to run at startup.
        /// </summary>
        /// <returns></returns>
        public static bool GetStartup()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            return key.GetValue(Application.ProductName, null) != null;
        }

        /// <summary>
        /// Checks whether this is the first time the application has been run
        /// </summary>
        /// <returns></returns>
        public static bool IsFirstRun()
        {
            return Database.retrieve("Last Run") == null;
        }
    }
}
