using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIT.Models
{
    /// <summary>
    /// Обращение клиента
    /// </summary>
    public class Request
    {
        public int id { get; set; }

        /// <summary>
        /// Основание обращения (может быть другое обращение
        /// </summary>
        public Request BaseRequest { get; set; }
        /// <summary>
        /// Дата и время обращения
        /// </summary>
        public DateTime Date {get;set;}
        /// <summary>
        /// Срок реакции
        /// </summary>
        public DateTime ReactionTime { get; set; }
        /// <summary>
        /// Срок выполнения
        /// </summary>
        public DateTime Deadline { get; set; }
            
        /// <summary>
        /// Способ подачи
        /// </summary>
        public MethodFeed Method_Feed { get; set; }
        /// <summary>
        /// Тип обращения (инцидент, запрос информации и т.д.)
        /// </summary>
        public RequestType Request_Type { get; set; }
        /// <summary>
        /// Срочость/приоритет
        /// </summary>
        public Priority Urgency { get; set; }
        /// <summary>
        /// Состояние обращения
        /// </summary>
        public RequestState State { get; set; }
        /// <summary>
        /// Тема обращения
        /// </summary>
        public string Topic { get; set; }
        /// <summary>
        /// Текст обращения
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Приложенные файлы
        /// </summary>
        public List<FileObject> Files { get; set; }

        /// <summary>
        /// Заявитель
        /// </summary>
        public User Client { get; set; }
        /// <summary>
        /// Ответственный
        /// </summary>
        public User Responsible { get; set; }
        /// <summary>
        /// Список исполнителей
        /// </summary>
        public List<User> Executors { get; set; }
        /// <summary>
        /// Наблюдатели (заинтересованные лица, руководители и т.д.)
        /// </summary>
        public List<User> Observers { get; set; }

        public bool isDeleted { get; set; }

    }
}
