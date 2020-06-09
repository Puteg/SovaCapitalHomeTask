using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Hosting;
using SovaCapitalHomeTask.Hubs;
using SovaCapitalHomeTask.Models;

namespace SovaCapitalHomeTask.Services
{
    public class MessageService : BackgroundService
    {
        private readonly IMessageRepository _messageRepo;
        private readonly IHubContext<MessageHub, IMessageHub> _hubContext;
        private const int TaskDelayMilliseconds = 2000;

        public MessageService(IMessageRepository messageRepo, IHubContext<MessageHub, IMessageHub> hubContext)
        {
            _messageRepo = messageRepo;
            _hubContext = hubContext;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var message = new Message
                {
                    Text = $"Текущее время {DateTime.Now:T}"
                };

                _messageRepo.Add(message);

                await _hubContext.Clients.All.GetNewMessage(message);
                await Task.Delay(TaskDelayMilliseconds, stoppingToken);
            }
        }
    }
}
