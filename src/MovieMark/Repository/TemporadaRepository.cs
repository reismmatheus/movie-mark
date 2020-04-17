using MovieMark.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MovieMark.Models.DatabaseMode;

namespace MovieMark.Repository
{
    public class TemporadaRepository : ITemporadaRepository
    {
        private readonly ApplicationDbContext contexto;
        public TemporadaRepository(ApplicationDbContext contexto)
        {
            this.contexto = contexto;
        }

        public TemporadaRepository()
        {
        }

        public void Insert()
        {
        }

        public List<Temporada> GetAll()
        {
            return contexto.Set<Temporada>().ToList();
        }
    }
}
