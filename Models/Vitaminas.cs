using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AP2_Yunilda.Models
{
    public class Vitaminas
    {
        [Key]
        public int VitaminaId { get; set; }

        [Required(ErrorMessage = "Debe indicar la descripción.")]
        [MinLength(3, ErrorMessage = "La descripción debe tener al menos {1} caractéres.")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Debe indicar la Unidad de medida.")]
        public string UnidadMedida { get; set; }
        public double Existencia { get; set; }

        }
}