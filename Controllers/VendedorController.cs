using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Repository;

namespace SistemaVendas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendedorController : ControllerBase
    {
        private readonly VendedorRepository _repository;
        public VendedorController(VendedorRepository repository)
        {
            _repository = repository;
        }
    }
}