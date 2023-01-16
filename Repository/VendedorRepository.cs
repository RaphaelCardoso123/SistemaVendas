using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Context;
using SistemaVendas.Models;
using SistemaVendas.Dto;

namespace SistemaVendas.Repository
{
    public class VendedorRepository
    {
          //"_"(underline) significa que é global e pode ser acessada em qualquer classe
          private readonly VendasContext _context; 
          public VendedorRepository(VendasContext context)
          {
            _context = context;
          }


          //Precisa do SaveChanges pq está alterando/cadastrando o registro 
          public void Cadastrar(Vendedor vendedor)
          {
            _context.Vendedores.Add(vendedor);
            _context.SaveChanges(); 
          }


          //Não precia SaveChanges pq não está alterando/cadastrando o registro 
          public Vendedor ObterPorId(int id)                                
          {
            var vendedor = _context.Vendedores.Find(id);
            return vendedor;
          }


          public List<ObterVendedorDTO> ObterPorNome(string nome)
          {
            var vendedores = _context.Vendedores.Where(x => x.Nome.Contains(nome))
                                                .Select(x => new ObterVendedorDTO(x))
                                                .ToList();
            return vendedores;
          }


          //Precisa do SaveChanges pq está alterando/cadastrando o registro 
          public Vendedor AtualizarVendedor(Vendedor vendedor)
                                                              
          {
            _context.Vendedores.Update(vendedor);
            _context.SaveChanges(); 

            return vendedor;
          }

          public void DeletarVendedor(Vendedor vendedor)
          {
            _context.Vendedores.Remove(vendedor);
            _context.SaveChanges();
          }

    }
}