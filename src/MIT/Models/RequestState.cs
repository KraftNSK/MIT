﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIT.Models
{
    /// <summary>
    /// Статус обращения
    /// </summary>
    public class RequestState
    {
        public int id { get; set; }

        public string Status { get; set; }

        public string Description { get; set; }
    }
}
