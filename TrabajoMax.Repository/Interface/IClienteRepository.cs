using System;
using System.Collections.Generic;
using System.Text;
using TrabajoMax.Models;

namespace TrabajoMax.Repository.Interface
{
    public interface IClienteRepository
    {
        int CreateCliente(Cliente cliente);
        List<Cliente> FindClientes();
    }
}
