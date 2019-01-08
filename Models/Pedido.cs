using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidosHub.Models
{
    public class Pedido
    {
        public string Nome { get; set; }
        public string Produto { get; set; }
        public decimal Valor { get; set; }

    }
}
