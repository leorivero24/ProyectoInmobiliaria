// namespace ProyectoInmobiliaria.Models
// {
//     public class Inquilino
//     {
//         public int Id { get; set; }
//         public string DNI { get; set; }
//         public string Nombre { get; set; }
//         public string Apellido { get; set; }
//         public string Telefono { get; set; }
//         public string Email { get; set; }
//         public string Direccion { get; set; }
//     }
// }


using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoInmobiliaria.Models
{
    [Table("inquilino")] // Esto indica a EF Core que use la tabla "inquilino"
    public class Inquilino
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
