using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VentaLibrosAPI.Models
{
    public class DetalleCompraLibroModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public DateTime FechaCompra { get; set; }

        public int cantidad { get; set; }

        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public ClienteModel Cliente { get; set; }

        public int LibroId { get; set; }
        [ForeignKey("LibroId")]
        public LibroModel Libro { get; set; }
    }
}
