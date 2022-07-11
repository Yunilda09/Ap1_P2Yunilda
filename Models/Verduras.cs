using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AP2_Yunilda.Models
{
    public class Verduras
    {
        [Key]
        public int VerduraId { get; set; }
        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "Debe tener el nombre.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe indicar las Observaciones.")]
        public string Observaciones { get; set; }

        [ForeignKey("VerduraId")]
       public virtual List<VerdurasDetalle> Detalle { get; set; } = new List<VerdurasDetalle>();

        public override string ToString()
        {
            return $"Verduras: Id={VerduraId}, Nombre={Nombre}, Observaciones={Observaciones}";
        }

        public Verduras()
        {
            FechaCreacion = DateTime.Today;
            Observaciones = string.Empty;
        }
    
    }
}