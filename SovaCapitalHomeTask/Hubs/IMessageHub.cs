using System.Collections.Generic;
using System.Threading.Tasks;
using SovaCapitalHomeTask.Models;

namespace SovaCapitalHomeTask.Hubs
{
    public interface IMessageHub
    {
        /// <summary>
        /// Получить все сообщения
        /// </summary>
        Task GetAllMessages(IList<Message> messages);

        /// <summary>
        /// Получить новое сообщения
        /// </summary>
        Task GetNewMessage(Message message);
    }
}
