using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Dto;
using SistemaVendas.Models;
using SistemaVendas.Repository;
using Microsoft.AspNetCore.Mvc;

namespace SistemaVendas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemPedidoController : ControllerBase
    {
        
        private readonly ItemPedidoRepository _repository;
        public ItemPedidoController(ItemPedidoRepository repository)

        {
            _repository = repository;
        }


        [HttpPost]
        public IActionResult Cadastrar(CadastrarItemPedidoDTO dto)
        {
            var itemPedido = new ItemPedido(dto);
            _repository.Cadastrar(itemPedido);
            return Ok(itemPedido);
        }

    }
}