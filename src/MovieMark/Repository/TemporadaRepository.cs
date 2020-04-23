using MovieMark.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MovieMark.Models.DatabaseMode;

namespace MovieMark.Repository
{
    public interface ITemporadaRepository
    {
        void Insert(Temporada temporada);
        List<Temporada> GetAll(int id = 0);
        Temporada Get(int id);
    }
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

        public void Insert(Temporada temporada)
        {
            contexto.Set<Temporada>().Add(temporada);
            contexto.SaveChanges();
        }

        public List<Temporada> GetAll(int id = 0)
        {
            return id == 0 ? contexto.Set<Temporada>().ToList() : contexto.Set<Temporada>().Where(x => x.SerieId == id).ToList();
        }

        public Temporada Get(int id)
        {
            var temporada = contexto.Set<Temporada>().Where(x => x.Id == id).FirstOrDefault();

            temporada.ListaEpisodio.AddRange(contexto.Set<Episodio>().Where(x => x.TemporadaId == temporada.Id).ToList());

            return temporada;
        }

        public List<Temporada> GetByIdSerie(int id)
        {
            return contexto.Set<Temporada>().Where(x => x.SerieId == id).ToList();
        }
    }
}
