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
        List<Episodio> GetByIdTemporada(int id);
    }

    public class EpisodioRepository : IEpisodioRepository
    {
        private readonly ApplicationDbContext context;

        public EpisodioRepository()
        {
        }

        public EpisodioRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Episodio Get(int id)
        {
            return context.Set<Episodio>().FirstOrDefault(x => x.Id == id);
        }

        public List<Episodio> GetAll()
        {
            return context.Set<Episodio>().ToList();
        }

        public List<Episodio> GetByIdTemporada(int id)
        {
            return context.Set<Episodio>().Where(x => x.TemporadaId == id).ToList();
        }

        public void Insert(Episodio episodio)
        {
            context.Set<Episodio>().Add(episodio);
            context.SaveChanges();
        }
    }
}
