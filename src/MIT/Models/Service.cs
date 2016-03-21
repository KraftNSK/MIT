using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIT.Models
{
    public class Service
    {
        public int id { get; set; }

        public Service Parent { get; set; }

        public bool isGroup { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int SLA_MinReactionTimeMinutes { get; set; }

        public int SLA_TimeDone { get; set; }

        public User Responsible { get; set; }

    }
}
