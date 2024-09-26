using CobranzasApp.Models;

namespace CobranzasApp.Services
{
    public interface IClienteService
    {
        IEnumerable<Clientes> GetClientes();
        Clientes GetClienteById(int id);
    }
}
