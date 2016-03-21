using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIT.Models
{
    /// <summary>
    /// The type of request (incident, service request, ...)
    /// </summary>
    public class RequestType
    {
        public int id { get; set; }

        public string Type { get; set; }
        
    }
}
