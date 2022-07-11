using Microsoft.EntityFrameworkCore;
using AP2_Yunilda.DAL;
using AP2_Yunilda.Models;

namespace AP2_Yunilda.BLL
{
    public class VitaminasBLL
    {
        private Contexto _contexto;
        public VitaminasBLL(Contexto contexto)
        {
            _contexto = contexto;
        }


        public Vitaminas? Buscar(int Id)
        {
            return _contexto.Vitaminas
                .Where(v => v.VitaminaId == Id)
                .AsNoTracking()
                .SingleOrDefault();
        }
        public List<Vitaminas> GetList()
        {
            return _contexto.Vitaminas
                .AsNoTracking()
                .ToList();
        }
    }
}