using Moq;
using System;
using System.Collections.Generic;
using TrabajoMax.Business;
using TrabajoMax.Business.Interface;
using TrabajoMax.Models;
using TrabajoMax.Repository.Interface;
using Xunit;

namespace ClientesTest
{
    public class ClientesTesting
    {

        private readonly IClienteBusiness _clienteBusiness;
        Mock<IClienteRepository> _clienteRepositoryM = new Mock<IClienteRepository>();

        public ClientesTesting()
        {
            _clienteBusiness = new ClienteBusiness(_clienteRepositoryM.Object);
        }


       
        [Fact]
        public void FindClientesTest()
        {
            //arrangement

            List<Cliente> clientes = new List<Cliente>()
            {
                new Cliente(){NombreApellido="Franco Magallanes"},

                 new Cliente(){NombreApellido="Raul Cazares"},

                   new Cliente(){NombreApellido="Perdro Paredes"}

            };

            _clienteRepositoryM.Setup(x => x.FindClientes()).Returns(clientes);

            //act

            var result = _clienteBusiness.FindClientes();

            //assert

            Assert.True(result.Count > 0);
        }

    
    }
}
