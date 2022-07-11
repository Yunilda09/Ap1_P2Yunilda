using Microsoft.EntityFrameworkCore;
using AP2_Yunilda.Models;

namespace AP2_Yunilda.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Verduras> Verduras { get; set; }
        public DbSet<Vitaminas> Vitaminas { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Vitaminas>().HasData(
                new Vitaminas
                {
                    VitaminaId = 1,
                    Descripcion = "Vitamina A (mg)",
                    UnidadDeMedidas= 1.0
                },

                 new Vitaminas
                 {
                     VitaminaId = 2,
                     Descripcion = "Vitamina B1 (mg)",
                     UnidadDeMedidas= 1.5
                 },

                  new Vitaminas
                {
                    VitaminaId = 3,
                    Descripcion = "Vitamina B2 (mg)",
                    UnidadDeMedidas = 1.7
                },

                 new Vitaminas
                {
                    VitaminaId = 4,
                    Descripcion = "Vitamina B6 (mg)",
                    UnidadDeMedidas = 2.0
                },

                 new Vitaminas
                {
                    VitaminaId = 5,
                    Descripcion = "Vitamina B12 (mcg)",
                    UnidadDeMedidas = 2.4
                },

                 new Vitaminas
                {
                    VitaminaId = 6,
                    Descripcion = "Vitamina C (mg)",
                    UnidadDeMedidas = 500
                },

                new Vitaminas
                {
                    VitaminaId = 7,
                    Descripcion = "Vitamina D (mg)",
                    UnidadDeMedidas = 5
                },
                
                 new Vitaminas
                {
                    VitaminaId = 8,
                    Descripcion = "Vitamina E (mg)",
                    UnidadDeMedidas = 670
                },

                 new Vitaminas
                {
                    VitaminaId = 9,
                    Descripcion = "Vitamina K (mcg)",
                    UnidadDeMedidas = 90 - 120
                },

                 new Vitaminas
                {
                    VitaminaId = 10,
                    Descripcion = "Vitamina B3 (mg)",
                    UnidadDeMedidas = 14 - 16 
                }

                ) ;
        }
    }
}