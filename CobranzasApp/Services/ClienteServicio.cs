using CobranzasApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace CobranzasApp.Services
{

    public class ClienteService : IClienteService
    {
        private readonly List<Clientes> _clientes = new List<Clientes>
        {
            new Clientes { Id = 1, Nombre = "Prisila Escobar",
            Banco = "BanQuito" ,
            NumeroCuenta = "0987773" ,
            Telefono = "0992880281" ,
             Correo = "priscils@example.com",
             ValorDeuda = 43000,
             PropuestaPago = "Se propone pagar a 6 meses plazo sinintereses." ,
            fechaRegistro = DateTime.Now },
            new Clientes { Id = 2,  Nombre = "Angel Escobar",
            Banco = "BanQuitos" , 
            NumeroCuenta = "0933443" ,
            Telefono = "0992880280" ,
             Correo = "angel@example.com",
             ValorDeuda = 89000,
             PropuestaPago = "Se propone pagar a 12 meses.",
             fechaRegistro = DateTime.Now}
        };

        public IEnumerable<Clientes> GetClientes()
        {
            return _clientes;
        }

        public Clientes GetClienteById(int id)
        {
            return _clientes.FirstOrDefault(c => c.Id == id);
        }
    }
}
