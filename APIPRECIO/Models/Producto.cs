using System.ComponentModel.DataAnnotations;

namespace APIPRECIO.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        [Required]
        public string Nombre { get; set; }
       
        public string Descripcion { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public float Precio { get; set; }

        //public List<Compra> Compras { get; set; }


    }
}