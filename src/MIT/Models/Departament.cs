using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MIT.Models
{
    public class Departament
    {

        public int id { get; set; }

        public Departament Parent { get; set; }

        public string Name { get; set; }
        
        /// <summary>
        /// Руководитель подразделения
        /// </summary>
        [Required]
        public User Manager { get; set; }
        public string Description { get; set; }
    }
}
