using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIT.Models
{
    public class History
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        public User Responsible { get; set; }
        public RequestState Status { get; set; }
        public string Description { get; set; }
        public User UserChange { get; set; }

    }
}
