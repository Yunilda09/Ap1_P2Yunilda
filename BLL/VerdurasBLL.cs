using Microsoft.EntityFrameworkCore;
using AP2_Yunilda.DAL;
using AP2_Yunilda.Models;
using System.Linq.Expressions;

namespace AP2_Yunilda.BLL
{
    public class VerdurasBLL
    {
        private Contexto _contexto;

        public VerdurasBLL(Contexto contexto)
        {
            _contexto = contexto;
        }
        public bool Existe(int Id)
        {
            return _contexto.Verduras.Any(v => v.VerduraId == Id);
        }
        public bool Guardar(Verduras verdura)
        {
            bool paso = false;

            if (!Existe(verdura.VerduraId))
                paso = Insertar(verdura);
            else
                paso = Modificar(verdura);
               return paso;

        }
        private bool Insertar(Verduras verdura)
        {
            _contexto.Verduras.Add(verdura);
            //sumar el inventario nuevamente
            foreach (var item in verdura.Detalle)
            {
                var vitamina = _contexto.Vitaminas.Find(item.VitaminaId);
                vitamina.Existencia += item.Cantidad;
            }
         
            bool insertar = _contexto.SaveChanges() >0;
             _contexto.Entry(verdura).State = EntityState.Detached;
             return insertar;

               
        }
        
         private bool Modificar(Verduras verdura)
        {

            //buscar el detalle anterior
            var anterior = _contexto.Verduras
           .Where(v => v.VerduraId == verdura.VerduraId)
           .Include(v => v.Detalle)
           .AsNoTracking()
           .SingleOrDefault();


            //restar el inventario del detalle anterior
            foreach (var item in anterior.Detalle)
            {
                var vitamina = _contexto.Vitaminas.Find(item.VitaminaId);

                vitamina.Existencia -= item.Cantidad;
            }

            //borrar los items del detalle anterior
            _contexto.Database.ExecuteSqlRaw($"DELETE FROM VerdurasDetalle WHERE VerduraId={verdura.VerduraId};");

            //sumar el inventario nuevamente
            foreach (var item in verdura.Detalle)
            {
                var vitamina = _contexto.Vitaminas.Find(item.VitaminaId);
                vitamina.Existencia += item.Cantidad;

                _contexto.Entry(item).State = EntityState.Added;
            }

            _contexto.Entry(verdura).State = EntityState.Modified;

            var guardo = _contexto.SaveChanges() > 0;
            _contexto.Entry(verdura).State = EntityState.Detached;
            return guardo;
        }
       public bool Eliminar(Verduras verdura)
        {
              _contexto.Verduras.Add(verdura);
            //sumar el inventario nuevamente
            foreach (var item in verdura.Detalle)
            {
                var vitamina = _contexto.Vitaminas.Find(item.VitaminaId);
                vitamina.Existencia -= item.Cantidad;

            }
                _contexto.Entry(verdura).State = EntityState.Deleted;

                bool elimino = _contexto.SaveChanges() > 0;
                _contexto.Entry(verdura).State = EntityState.Detached;
                return elimino;
        }


        public Verduras? Buscar(int verdura)
        {
            return _contexto.Verduras
                .Include(v => v.Detalle)
                .Where(v => v.VerduraId == verdura)
                .AsNoTracking()
                .SingleOrDefault();
        }
        public List<Verduras> GetList()
        {
            return _contexto.Verduras.AsNoTracking().ToList();
        }
        /* public List<Verduras> BuscarFecha( DateTime fecha, DateTime fecha1)
        {
            var fechas = _contexto.Verduras
            .Where(f => f.Fecha.Date == fecha.Date || f.Fecha.Date == fecha1.Date)
            .AsNoTracking().ToList();
            return fechas;
        }*/
    }
}