using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Context;
using SistemaVendas.Models;

namespace SistemaVendas.Repository
{
    public class VendedorRepository
    {
          private readonly VendasContext _context; //O "_"(underline) significa que é global e pode ser acessada em qualquer classe
          public VendedorRepository(VendasContext context)
          {
            _context = context;
          }

          public void Cadastrar(Vendedor vendedor)
          {
            _context.Vendedores.Add(vendedor);
            _context.SaveChanges();
          }

          public Vendedor ObterPorId(int id)
          {
            var vendedor = _context.Vendedores.Find(id);
            return vendedor;
          }

    }
}