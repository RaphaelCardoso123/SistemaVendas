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


          public ItemPedido ObterPorId(int id)
        {
            var itemPedido = _context.ItensPedido.Include(x => x.Pedido)
                                                 .Include(x => x.Servico)
                                                 .FirstOrDefault(x => x.Id == id);
            return itemPedido;
        }


          public void DeletarItemPedido(ItemPedido itemPedido){
            _context.ItensPedido.Remove(itemPedido);
            _context.SaveChanges();
        }
    }
}