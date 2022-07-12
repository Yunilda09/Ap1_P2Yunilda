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
                    Descripcion = "Vitamina A ",
                    UnidadMedida = "mg",
                    Existencia = 0
                },

                 new Vitaminas
                 {
                     VitaminaId = 2,
                     Descripcion = "Vitamina B1 ",
                     UnidadMedida = "mg",
                    Existencia = 0
                 },

                  new Vitaminas
                  {
                      VitaminaId = 3,
                      Descripcion = "Vitamina B2 ",
                      UnidadMedida = "mg",
                    Existencia = 0
                  },

                 new Vitaminas
                 {
                     VitaminaId = 4,
                     Descripcion = "Vitamina B6 ",
                     UnidadMedida = "mg",
                    Existencia = 0
                 },

                 new Vitaminas
                 {
                     VitaminaId = 5,
                     Descripcion = "Vitamina B12 ",
                     UnidadMedida = "mg",
                    Existencia = 0
                 },

                 new Vitaminas
                 {
                     VitaminaId = 6,
                     Descripcion = "Vitamina C",
                     UnidadMedida = "mg",
                    Existencia = 0
                 },

                new Vitaminas
                {
                    VitaminaId = 7,
                    Descripcion = "Vitamina D ",
                    UnidadMedida = "mg",
                    Existencia = 0
                },

                 new Vitaminas
                 {
                     VitaminaId = 8,
                     Descripcion = "Vitamina E ",
                     UnidadMedida = "mg",
                    Existencia = 0
                 },

                 new Vitaminas
                 {
                     VitaminaId = 9,
                     Descripcion = "Vitamina K ",
                     UnidadMedida = "mg",
                    Existencia = 0
                 },

                 new Vitaminas
                 {
                     VitaminaId = 10,
                     Descripcion = "Vitamina B3 ",
                     UnidadMedida = "mg",
                    Existencia = 0
                 }

                );
        }
    }
}