using MovieMark.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MovieMark.Models.DatabaseMode;

namespace MovieMark.Repository
{
    public interface IUserTemporadaEpisodioRepositoy
    {
        void Insert(UserTemporadaEpisodio userTemporadaEpisodio);
        UserTemporadaEpisodio Get(int id);
        List<UserTemporadaEpisodio> GetBySerieId(int id);
        UserTemporadaEpisodio GetByIds(int temporadaId, int episodioId, int userSerieId);
        bool Delete(int id);
    }
    public class UserTemporadaEpisodioRepositoy : IUserTemporadaEpisodioRepositoy
    {
        private readonly ApplicationDbContext contexto;
        public UserTemporadaEpisodioRepositoy(ApplicationDbContext contexto)
        {
            this.contexto = contexto;
        }
        public UserTemporadaEpisodioRepositoy()
        {

        }
        public UserTemporadaEpisodio Get(int id)
        {
            return contexto.Set<UserTemporadaEpisodio>().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<UserTemporadaEpisodio> GetBySerieId(int id)
        {
            return contexto.Set<UserTemporadaEpisodio>().Where(x => x.UserSerieId == id).ToList();
        }

        public void Insert(UserTemporadaEpisodio userTemporadaEpisodio)
        {
            contexto.Set<UserTemporadaEpisodio>().Add(userTemporadaEpisodio);
            contexto.SaveChanges();
        }

        public bool Delete(int id)
        {
            var listaEpTempo = GetBySerieId(id);
            if(listaEpTempo == null)
            {
                return true;
            }
            contexto.Set<UserTemporadaEpisodio>().RemoveRange(listaEpTempo);
            contexto.SaveChanges();
            return true;
        }

        public UserTemporadaEpisodio GetByIds(int temporadaId, int episodioId, int userSerieId)
        {
            return contexto.Set<UserTemporadaEpisodio>().Where(x => x.TemporadaId == temporadaId && x.EpisodioId == episodioId && x.UserSerieId == userSerieId).ToList().FirstOrDefault();
        }
    }
}
