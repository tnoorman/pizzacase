using System.Net.WebSockets;

namespace PizzaCase.Models;

public interface IWebSocketHandler
{
    Task Handle(Guid id, WebSocket websocket);
}