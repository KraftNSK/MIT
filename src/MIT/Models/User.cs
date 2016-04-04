using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MIT.Models
{
    public class User
    {
        [Key]
        public int id {get;set;}

        /// <summary>
        /// Уровень доступа, определяется маской из восьми бит. Далее описание начиная с младших битов: 
        /// 1 - администраторский доступ (настройки)
        /// 2 - доступ ко всем справочникам системы
        /// 3 - доступ ко всем документам системы
        /// 4 - доступ ко всем отчетам
        /// 5 - админский доступ к подсистеме ServiceDesk
        /// 6 - доступ к подсистеме учета конфигураций и изменений
        /// 7 - пользовательский доступ к подсистеме ServiceDesk
        /// 8 - резерв
        /// </summary>
        public byte AccessLevel { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumbers { get; set; }
        public string Password { get; set; }
        public Departament UserDepartamet { get; set; }
        public Organization UserOrganization { get; set; }
        public Position UserPosition { get; set; }
        public bool isVIP { get; set; }
        public string LoginAD { get; set; }
        public string OfficeNumber { get; set; }

        public bool isDeleted { get; set; }
    }
}
