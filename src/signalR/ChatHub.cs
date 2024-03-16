using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub 
{
    public ChatHub()
    {
        Console.WriteLine("ChatHub created");
    }

    public async Task SendMessage(string user, string message)
    {
        Console.WriteLine("SendMessage called: " + user + " - " + message);
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
