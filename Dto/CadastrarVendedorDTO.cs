using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVendas.Dto
{
    public class CadastrarVendedorDTO
    {
        //Dto significa Data Transfer Object
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}