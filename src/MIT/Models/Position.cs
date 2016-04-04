using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIT.Models
{
    /// <summary>
    /// Должность
    /// </summary>
    public class Position
    {
        public int id { get; set; }

        public string Name { get; set; }
        public bool isDeleted { get; set; }
    }
}
