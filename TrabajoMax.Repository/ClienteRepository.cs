using System;
using System.Collections.Generic;
using System.Text;
using TrabajoMax.Models;
using TrabajoMax.Repository.Interface;

namespace TrabajoMax.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly TabajoMaxContext _context;

        public ClienteRepository(TabajoMaxContext context)
        {
            _context = context;
        }

        public int CreateCliente(Cliente cliente)
        {
            _context.Cliente.Add(cliente);

            _context.SaveChanges();

            return cliente.Id;
        }
    }
}
