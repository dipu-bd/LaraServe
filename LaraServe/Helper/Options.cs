using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaraServe.Helper
{
    public static class Options
    {
        /// <summary>
        /// Gets or sets whether to run this application at start of the computer.
        /// </summary>
        public static bool RunAtStartup
        {
            get
            {
                return Utils.GetStartup();
            }
            set
            {
                Utils.SetStartup(value);
            }
        }

        /// <summary>
        /// Gets or sets whether to run this application at start of the computer.
        /// </summary>
        public static bool StartMinimized
        {
            get
            {
                return (int) Database.retrieve("Start Minimized", 0) != 0;
            }
            set
            {
                Database.store("Start Minimized", value ? 1 : 0, Microsoft.Win32.RegistryValueKind.DWord);
            }
        }

        /// <summary>
        /// Gets or sets the last time this application was open.
        /// </summary>
        public static DateTime LastRun
        {
            get
            {
                long data = (long)Database.retrieve("Last Run", 0);
                if (data == 0)
                {
                    return DateTime.Now;
                }
                return DateTime.FromBinary((long)data);
            }
            set
            {
                Database.store("Last Run", value.ToBinary(), Microsoft.Win32.RegistryValueKind.QWord);
            }
        }
    }
}
