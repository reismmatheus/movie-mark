using MovieMark.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MovieMark.Models.DatabaseMode;

namespace MovieMark.Repository
{
    public interface IEpisodioRepository
    {
        void Insert(Episodio episodio);
        Episodio Get(int id);
        List<Episodio> GetAll();
        List<Episodio> GetByTemporadaId(int id);
        bool Update(Episodio episodio);
        bool Delete(int id);
    }

    public class EpisodioRepository : IEpisodioRepository
    {
        private readonly ApplicationDbContext contexto;

        public EpisodioRepository()
        {
        }

        public EpisodioRepository(ApplicationDbContext contexto)
        {
            this.contexto = contexto;
        }

        public bool Delete(int id)
        {
            var getEpisodio = contexto.Set<Episodio>().FirstOrDefault(x => x.Id == id);
            if (getEpisodio == null)
            {
                return false;
            }
            contexto.Set<Episodio>().Remove(getEpisodio);
            contexto.SaveChanges();
            return true;
        }

        public Episodio Get(int id)
        {
            return contexto.Set<Episodio>().FirstOrDefault(x => x.Id == id);
        }

        public List<Episodio> GetAll()
        {
            return contexto.Set<Episodio>().ToList();
        }

        public List<Episodio> GetByTemporadaId(int id)
        {
            return contexto.Set<Episodio>().Where(x => x.TemporadaId == id)?.ToList();
        }

        public void Insert(Episodio episodio)
        {
            contexto.Set<Episodio>().Add(episodio);
            contexto.SaveChanges();
        }

        public bool Update(Episodio episodio)
        {
            var getEpisodio = contexto.Set<Episodio>().FirstOrDefault(x => x.Id == episodio.Id);
            if (getEpisodio == null)
            {
                return false;
            }
            getEpisodio.Nome = episodio.Nome;
            contexto.Set<Episodio>().Update(getEpisodio);
            contexto.SaveChanges();
            return true;
        }
    }
}
