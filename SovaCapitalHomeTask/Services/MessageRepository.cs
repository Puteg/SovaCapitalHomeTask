using System.Collections.Generic;
using SovaCapitalHomeTask.Models;

namespace SovaCapitalHomeTask.Services
{
    public class MessageRepository : IMessageRepository
    {
        private readonly IList<Message> _messages;

        public MessageRepository()
        {
            _messages = new List<Message>();
        }

        public IList<Message> GetAll()
        {
            return _messages;
        }

        public void Add(Message message)
        {
            _messages.Add(message);
        }
    }
}
