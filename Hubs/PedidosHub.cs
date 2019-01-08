using Microsoft.AspNetCore.SignalR;
using PedidosHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosHub.Hubs
{
    public class PedidosHub : Hub
    {
        public async Task EnviarPedido(string user, Pedido pedido)
        {
            await Clients.All.SendAsync("ReceberPedido", user, pedido);

        }
    }
}
