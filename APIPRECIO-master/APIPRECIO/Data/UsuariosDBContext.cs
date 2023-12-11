using APIPRECIO.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace APIProductos.Data
{
    public class UsuariosDBContext : DbContext
    {
        public UsuariosDBContext(
            DbContextOptions<UsuariosDBContext> options) : base(options)
        {

        }

        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().HasData(

                new Usuarios
                {   Nombre="Juan David",
                    Correo="rjuandavid2002@gmailcom",
                    Contrasena = "El_gatofly2"

                }

                );
        }


    }
}
