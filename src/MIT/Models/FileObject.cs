using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIT.Models
{
    public class FileObject
    {
        public int id { get; set; }
        public string Path { get; set; }
        public string Type { get; set; }

        public bool isDeleted { get; set; }
    }
}
