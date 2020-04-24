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
        List<Temporada> GetAll();
        Temporada Get(int id);
        List<Temporada> GetByIdSerie(int id);
        bool Update(Temporada temporada);
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

        public List<Temporada> GetAll()
        {
            return contexto.Set<Temporada>().ToList();
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

        public bool Update(Temporada temporada)
        {
            var getTemporada = contexto.Set<Temporada>().FirstOrDefault(x => x.Id == temporada.Id);
            if (getTemporada == null)
            {
                return false;
            }
            getTemporada.Nome = temporada.Nome;
            contexto.Set<Temporada>().Update(getTemporada);
            contexto.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var getTemporada = contexto.Set<Temporada>().FirstOrDefault(x => x.Id == id);
            if (getTemporada == null)
            {
                return false;
            }
            contexto.Set<Temporada>().Remove(getTemporada);
            contexto.SaveChanges();
            return true;
        }
    }
}
