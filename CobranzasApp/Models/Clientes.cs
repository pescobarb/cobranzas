namespace CobranzasApp.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Banco { get; set; }
        public string NumeroCuenta { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public Double ValorDeuda { get; set; }
        public string PropuestaPago { get; set; }

         public DateTime fechaRegistro { get; set; }

    }
}
