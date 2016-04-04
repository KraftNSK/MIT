using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIT.Models
{
    /// <summary>
    /// Способ подачи обращения
    /// </summary>
    public class MethodFeed
    {
        public int id { get; set; }

        public string Method { get; set; }

        public string Description { get; set; }
        public bool isDeleted { get; set; }
    }
}
