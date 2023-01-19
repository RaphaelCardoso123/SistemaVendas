using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Dto;

namespace SistemaVendas.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int VendedorId { get; set; }//VendedorId é uma chave estrangeira..
        public Vendedor Vendedor { get; set; }//que vem de Vendedor da classe Vendedor.
        public int ClienteId { get; set; } //Aqui o msm que o ex. acima.
        public Cliente Cliente { get; set; }//Aqui o msm que o ex. acima.


        public Pedido()
        {

        }

        public Pedido(CadastrarPedidoDTO dto)
        {
            Data = dto.Data;
            VendedorId = dto.VendedorId;
            ClienteId = dto.ClienteId;
        }
    }
}