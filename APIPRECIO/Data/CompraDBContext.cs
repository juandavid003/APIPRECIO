using APIPRECIO.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;

namespace APIProductos.Data
{
    public class CompraDBContext : DbContext
    {
        public CompraDBContext(
            DbContextOptions<CompraDBContext> options) : base(options)
        {

        }

        //public DbSet<Producto> Productos { get; set; }
        //public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<Compra> Compra { get; set; }
        public DbSet<Producto> Producto { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

           // modelBuilder.Entity<Compra>().HasData(

           //    new Compra
           //    {
           //        IdCompra = 1,
           //        IdProducto = 1,
           //        Nombre = "4444",
           //        Cantidad = 12,
           //        FechaCompra = DateTime.Now
           //    }
           //);

            //modelBuilder.Entity<Compra>()
            //.HasKey(pc => new { pc.IdProducto, pc.Nombre });

            //modelBuilder.Entity<Compra>()
            //    .HasOne(pc => pc.Producto)
            //    .WithMany(p => p.Compras)
            //    .HasForeignKey(pc => pc.IdCompra);

            //modelBuilder.Entity<Compra>()
            //    .HasOne(pc => pc.Usuarios)
            //    .WithMany(c => c.Compras)
            //    .HasForeignKey(pc => pc.Nombre);
        }
    }
}
