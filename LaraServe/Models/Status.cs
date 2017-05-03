using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaraServe.Models
{
    public enum Status
    {
        /// <summary>
        /// The status is not set.
        /// </summary>
        Unknown,

        /// <summary>
        /// The project is up and running.
        /// </summary>
        Active,

        /// <summary>
        /// The project is not running or disabled by the user.
        /// </summary>
        Inactive,

        /// <summary>
        /// Failed to start the project.
        /// </summary>
        Failing
    }
}
