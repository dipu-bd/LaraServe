using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace LaraServe.Models
{
    class Project
    {
        private Dictionary<string, string> commands;

        /// <summary>
        /// Construct a new project.
        /// </summary>
        public Project()
        {
            Port = 8080;
            Host = "127.0.0.1";
            Status = Status.Unknown;
            commands = new Dictionary<string, string>();
        }
                        
        /// <summary>
        /// Gets or sets the location of the project.
        /// </summary>
        public Directory Location { get; set; }

        /// <summary>
        /// Gets or sets the name of this project.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the commands to run.
        /// </summary>
        public Dictionary<string, string> Commands
        {
            get { return commands.; }
        }

        /// <summary>
        /// Gets or sets the host.
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Gets or sets the port number.
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Gets or sets the current status.
        /// </summary>
        public Status Status { get; set; }
        
        /// <summary>
        /// Gets or sets whether to use secured https protocol
        /// </summary>
        public bool UseSecure { get; set; }

        /// <summary>
        /// Gets the URL where this project should be running.
        /// </summary>
        /// <returns></returns>
        public string URL
        {
            get
            {
                string protocol = UseSecure ? "https" : "http";
                return string.Format("{0}://{1}:{2}", protocol, Host, Port);
            }
        }

        /// <summary>
        /// Adds a new command to the list.
        /// </summary>
        /// <param name="name">Name of the command (keep it short).</param>
        /// <param name="command">The command to execute.</param>
        public void AddCommand(string name, string command)
        {
            if (commands.ContainsKey(name))
            {
                throw new Exception("Another command with similar name exists");
            }
            else
            {
                commands.Add(name, command);
            }
        }

    }
}