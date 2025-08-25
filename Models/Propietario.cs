using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoInmobiliaria.Models
{
    [Table("propietario")] // Le indicamos a EF Core que use la tabla "propietario"
    public class Propietario
    {
        public int Id { get; set; }
        public string DNI { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Direccion { get; set; } = null!;
    }
}
