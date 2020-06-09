using System.Collections.Generic;
using SovaCapitalHomeTask.Models;

namespace SovaCapitalHomeTask.Services
{
    public interface IMessageRepository
    {
        /// <summary>
        /// Получить всё
        /// </summary>
        /// <returns>Сообщения</returns>
        IList<Message> GetAll();

        /// <summary>
        /// Добавить
        /// </summary>
        /// <param name="message">Сообщение</param>
        void Add(Message message);
    }
}
