using System.ComponentModel.DataAnnotations;

namespace APIPRECIO.Models
{
    public class Compra
    {
        [Key]
        public int IdCompra { get; set; }
        [Required]

        public int Codigo { get; set; }
        public int IdProducto { get; set; }
        [Required]
        public string Nombre { get; set; }

        [Required]
        public int Cantidad { get; set; }

        public DateTime  FechaCompra { get; set; }

        //public Usuarios Usuarios { get; set; }

        //public Producto Producto { get; set; }

    }
}