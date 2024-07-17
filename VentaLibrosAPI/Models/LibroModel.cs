using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VentaLibrosAPI.Models
{
    public class LibroModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string Titulo { get; set; }
        public DateOnly Publicacion { get; set; }
        [Required]
        public Decimal Precio { get; set; }

        
        public int AutorId { get; set; }
        [ForeignKey("AutorId")]
        public AutorModel Autor { get; set; }

        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public CategoriaModel Categoria { get; set;}
    }
}
