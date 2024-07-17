using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VentaLibrosAPI.Models
{
    public class AutorModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string Nombre { get; set; }
        
        public int NacionalidadId { get; set; }
        [ForeignKey("NacionalidadId")]
        public NacionalidadModel Nacionalidad { get; set; }
    }
}
