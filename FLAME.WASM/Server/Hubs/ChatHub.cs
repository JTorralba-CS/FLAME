using Microsoft.AspNetCore.SignalR;

namespace FLAME.WASM.Server.Hubs;

public class ChatHub : Hub
{
    public Task TX(String User, String Message)
    {
        return Clients.All.SendAsync("RX", User, Message);
    }
}
