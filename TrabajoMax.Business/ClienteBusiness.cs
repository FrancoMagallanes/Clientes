using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Linq;
using TrabajoMax.Business.Interface;
using TrabajoMax.Models;
using TrabajoMax.Repository.Interface;

namespace TrabajoMax.Business
{
    public class ClienteBusiness : IClienteBusiness
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteBusiness(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public int CreateCliente(Cliente cliente)
        {
            //
            //if (cliente.NombreApellido.IndexOf(@"0") >= 1)
            string[] numeros = { "1", "2", "3", "4","5","6","7","8","9","0"};
            for (int i = 0; i < numeros.Length; i++)
            {
               string nuevaI= i.ToString();
                if (cliente.NombreApellido.Contains(nuevaI))
                {
                    throw new Exception("El nombre y apellido no pueden llevar numeros");
                }
            }
            

            int response = _clienteRepository.CreateCliente(cliente);

            return response;
        }
    }
}
