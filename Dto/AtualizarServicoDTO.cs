using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Models;
using SistemaVendas.Dto;

namespace SistemaVendas.Dto
{
    public class AtualizarServicoDTO
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}