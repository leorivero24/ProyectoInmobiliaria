using Microsoft.EntityFrameworkCore;
using ProyectoInmobiliaria.Models;

namespace ProyectoInmobiliaria.Data
{
    public class InmobiliariaContext : DbContext
    {
        public InmobiliariaContext(DbContextOptions<InmobiliariaContext> options) : base(options) { }

        public DbSet<Propietario> Propietarios { get; set; }
        public DbSet<Inquilino> Inquilinos { get; set; }
    }
}
