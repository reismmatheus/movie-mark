using MovieMark.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MovieMark.Models.DatabaseMode;

namespace MovieMark.Repository
{
    public class SerieRepository : ISerieRepository
    {
        private readonly ApplicationDbContext contexto;
        public SerieRepository(ApplicationDbContext contexto)
        {
            this.contexto = contexto;
        }

        public SerieRepository()
        {
        }

        public void Insert()
        {
        }

        public List<Serie> GetAll()
        {
            return contexto.Set<Serie>().ToList();
        }
    }
}
