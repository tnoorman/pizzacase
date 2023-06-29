using System.Net.WebSockets;

namespace PizzaCase.Models;

public class SocketConnection
{
    public Guid Id { get; set; }
    public WebSocket WebSocket { get; set; }
}