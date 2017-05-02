using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace LaraServe.Models
{
    class Project
    {
        private string[] commands = { };
        private Directory location;
        private string name;
        private int port = 8000;
        private string host = "127.0.0.1";
        private Status status = Status.Unknown;
        
        /// <summary>
        /// Type of this project
        /// </summary>
        public abstract ProjectType ProjectType
        {
            get { return ProjectType.Unknown; }
        }
        
        /// <summary>
        /// Gets or sets the location of the project.
        /// </summary>
        public Directory Location
        {
            get { return location; }
            set { location = value; }
        }

        /// <summary>
        /// Gets or sets the name of this project.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        /// <summary>
        /// Gets or sets the host.
        /// </summary>
        public string Host
        {
            get { return host; }
            set { host = value; }
        }

        /// <summary>
        /// Gets or sets the port number.
        /// </summary>
        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        /// <summary>
        /// Gets or sets the current status.
        /// </summary>
        public Status Status
        {
            get { return status; }
            set { status = value; }
        }


        /// <summary>
        /// Gets the URL where this project should be running.
        /// </summary>
        /// <returns></returns>
        public string GetUrl()
        {
            return string.Format("http://{}:{}", host, port);
        }

    }
}