using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SovaCapitalHomeTask.Services;

namespace SovaCapitalHomeTask.Hubs
{
    public class MessageHub : Hub<IMessageHub>
    {
        private readonly IMessageRepository _messageRepo;

        public MessageHub(IMessageRepository messageRepo)
        {
            _messageRepo = messageRepo;
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.Caller.GetAllMessages(_messageRepo.GetAll());
        }
    }
}
