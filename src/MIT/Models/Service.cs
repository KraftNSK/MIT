using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIT.Models
{
    /// <summary>
    /// Услуга/сервис
    /// </summary>
    public class Service
    {
        public int id { get; set; }

        public Service Parent { get; set; }

        public bool isGroup { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        /// <summary>
        /// Минимальное время реакции
        /// </summary>
        public int SLA_MinReactionTimeMinutes { get; set; }
        /// <summary>
        /// Время за которое сервис должен быть восстановлен
        /// </summary>
        public int SLA_TimeDone { get; set; }
        /// <summary>
        /// Ответственный за сервис по умолчанию
        /// </summary>
        public User Responsible { get; set; }

    }
}
