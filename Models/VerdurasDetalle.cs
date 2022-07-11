using System.ComponentModel.DataAnnotations;

namespace AP2_Yunilda.Models
{
    public class VerdurasDetalle
    {
        [Key]
        public int Id { get; set; }
        public int VerduraId { get; set; }
        public int VitaminasId { get; set; }

         [Required(ErrorMessage = "Es Obligatorio.")]
        public double Cantidad { get; set; }

        public  VerdurasDetalle(double cantidad)
        {
            Cantidad = cantidad; 
        }
        public VerdurasDetalle(){}
    }
}