using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaraServe.Models
{
    class Command
    {
        public Command(string name, string command)
        {
            Name = name;
            Command = command;
            RunAtStartup = false;
        }

        /// <summary>
        /// Gets or sets the command.
        /// </summary>
        public string Command { get; set; }
        
        /// <summary>
        /// Gets or sets the name of this command.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets whether to run this command at start of the application.
        /// </summary>
        public bool RunAtStartup { get; set; }
    }
}
