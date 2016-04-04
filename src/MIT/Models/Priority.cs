using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIT.Models
{
    /// <summary>
    /// Приоритет
    /// </summary>
    public class Priority
    {
        public int id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Коэффициент приоритета
        /// </summary>
        public int Ratio { get; set; }

        public string Description { get; set; }
        public bool isDeleted { get; set; }
    }
}
