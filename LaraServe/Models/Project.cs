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
        public Project()
        {
            Port = 8080;
            Host = "127.0.0.1";
            Status = Status.Unknown;
        }
        
        /// <summary>
        /// Type of this project
        /// </summary>
        public ProjectType ProjectType
        {
            get { return ProjectType.Unknown; }
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
        public string GetUrl()
        {
            string protocol = UseSecure ? "https" : "http";
            return string.Format("{0}://{1}:{2}", protocol, Host, Port);
        }

    }
}