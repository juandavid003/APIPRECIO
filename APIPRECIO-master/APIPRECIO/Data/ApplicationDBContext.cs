using APIPRECIO.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace APIProductos.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(
            DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Producto> Producto { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Compra> Compras { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    IdProducto = 1,
                    Nombre = "Producto1",
                    Descripcion = "Descripcion Producto1",
                    Cantidad = 12,
                    Precio = 12
                }
            );

            modelBuilder.Entity<Usuarios>().HasData(
               new Usuarios
               {
                   Nombre = "Juan David",
                   Correo = "rjuandavid2002@gmailcom",
                   Contrasena = "El_gatofly2"
               }
            );

            modelBuilder.Entity<Compra>().HasData(
              new Compra
              {
                  IdCompra = 1,
                  IdProducto = 1,
                  Nombre = "Juan David",
                  Cantidad = 12,
                  FechaCompra = DateTime.Now
              }
          );

        }

    }

}

