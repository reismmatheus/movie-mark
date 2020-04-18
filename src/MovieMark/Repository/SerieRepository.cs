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

        public void Insert(Serie serie)
        {
            contexto.Set<Serie>().Add(serie);
            contexto.SaveChanges();
        }

        public List<Serie> GetAll()
        {
            var listaSerie = contexto.Set<Serie>().ToList();
            foreach (var serie in listaSerie)
            {
                var listaTemporada = contexto.Set<Temporada>().Where(x => x.SerieId == serie.Id).ToList();
                foreach (var temporada in listaTemporada)
                {
                    var listaEpisodio = contexto.Set<Episodio>().Where(x => x.TemporadaId == temporada.Id).ToList();
                    temporada.ListaEpisodio = listaEpisodio;
                }
                serie.ListaTemporada = listaTemporada;
            }
            return listaSerie;
        }

        public Serie GetById(int id)
        {
            var serie = contexto.Set<Serie>().FirstOrDefault(x => x.Id == id);
            var listaTemporada = contexto.Set<Temporada>().Where(x => x.SerieId == serie.Id).ToList();
            foreach (var temporada in listaTemporada)
            {
                var listaEpisodio = contexto.Set<Episodio>().Where(x => x.TemporadaId == temporada.Id).ToList();
                temporada.ListaEpisodio = listaEpisodio;
            }
            serie.ListaTemporada = listaTemporada;
            return serie;
        }
    }
}
