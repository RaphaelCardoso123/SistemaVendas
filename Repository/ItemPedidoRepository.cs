using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Context;
using SistemaVendas.Models;
using SistemaVendas.Dto;
using Microsoft.EntityFrameworkCore;

namespace SistemaVendas.Repository
{
    public class ItemPedidoRepository
    {
        private readonly VendasContext _context; 
          public ItemPedidoRepository(VendasContext context)
          {
            _context = context;
          }


        public ItemPedido Cadastrar(ItemPedido itemPedido)
          {
            _context.ItensPedido.Add(itemPedido);
            _context.SaveChanges(); 
            return itemPedido;

          }
    }
}