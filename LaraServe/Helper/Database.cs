using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;

namespace LaraServe
{
    public static class Database
    {
        /// <summary>
        /// Initiate the registry database. 
        /// (Must call this method before using any other member functions of the class).
        /// </summary>
        public static void Initiate()
        {
            RegistryKey SoftwareKey = Registry.LocalMachine.OpenSubKey("Software", true);
            RegistryKey AppNameKey = SoftwareKey.CreateSubKey(Application.ProductName);
            Root = AppNameKey.CreateSubKey(Application.ProductVersion);
        }

        /// <summary>
        /// Gets the applcation specific key.
        /// </summary>
        public static RegistryKey Root { get; private set; }

        /// <summary>
        /// Stores a value in the registry
        /// </summary>
        /// <param name="key">Value name</param>
        /// <param name="value">The value</param>
        /// <param name="kind">Type of the value</param>
        public static void store(string key, string value, RegistryValueKind kind = RegistryValueKind.String)
        {
            Root.SetValue(key, value, kind);
        }

        /// <summary>
        /// Retrieve a value by its name.
        /// </summary>
        /// <param name="key">Value name</param>
        /// <param name="defaultValue">Default value incase of failure in retrieval</param>
        /// <param name="options">Additional options</param>
        public static void retrieve(string key, object defaultValue = null, RegistryValueOptions options = RegistryValueOptions.None)
        {
            Root.GetValue(key, defaultValue, options);
        }

        /// <summary>
        /// Gets all values stored in the key.
        /// </summary>
        /// <returns></returns>
        public static List<string> values()
        {
            List<string> values = new List<string>();
            foreach (string s in Root.GetValueNames())
            {
                values.Add(Root.GetValue(s).ToString());
            }
            return values;
        }
    }
}
