using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIT.Models
{
    /// <summary>
    /// Категория обращения
    /// </summary>
    public class Category
    {
        public int id { get; set; }

        public Category Parent { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool isGroup { get; set; }

        public bool isDeleted { get; set; }

    }
}
