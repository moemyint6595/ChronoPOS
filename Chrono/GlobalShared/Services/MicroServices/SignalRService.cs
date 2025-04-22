using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalShared.Services.StaticServices;
using Microsoft.AspNetCore.SignalR.Client;

namespace GlobalShared.Services.MicroServices
{
    public class SignalRService(NotifierService _notifier, string Uri)
    {
        private readonly NotifierService Notifier = _notifier;
        private string EndPoint = Uri;

        private HubConnection? _hubConnection;
        public async Task CreateConnection()
        {
            string hubEndPoint = EndPoint + "/chathub";
            Console.WriteLine("hubEndPoint =>" + hubEndPoint);

            _hubConnection = new HubConnectionBuilder()
                .WithUrl(hubEndPoint)
                .WithAutomaticReconnect(new RetryPolicy())
                .WithKeepAliveInterval(TimeSpan.FromSeconds(15))
                .WithServerTimeout(TimeSpan.FromSeconds(30))
                .Build();

            OnListenSignalR();
            await OnStartHubConnection();
        }

        private void OnListenSignalR()
        {
            _hubConnection?.On<string, string>("ReceiveMessage", async (user, message) =>
            {
                await Notifier.Update(NotifierObjectName.SignalR, "", new { user, message } );
            });
        }
        private async Task OnStartHubConnection()
        {
            if(_hubConnection is not null)
            {
                await _hubConnection.StartAsync();
            }
              
        }
        public bool IsConnected => _hubConnection?.State == HubConnectionState.Connected;

        public void Send()
        {
            if(_hubConnection is not null)
                _hubConnection.SendAsync("SendMessage", "MoeMyintZaw", "Example message");
        }

        public class RetryPolicy : IRetryPolicy
        {
            public TimeSpan? NextRetryDelay(RetryContext retryContext)
            {
               return TimeSpan.FromSeconds(5);
            }
        }
    }
}
