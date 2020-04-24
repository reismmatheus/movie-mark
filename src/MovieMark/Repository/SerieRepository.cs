using Microsoft.EntityFrameworkCore;
using MovieMark.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MovieMark.Models.DatabaseMode;

namespace MovieMark.Repository
{
    public interface ISerieRepository
    {
        void Insert(Serie serie);
        List<Serie> GetAll();
        Serie Get(int id);
        bool Update(Serie serie);
        bool Delete(int id);
    }
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

        public Serie Get(int id)
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

        public bool Update(Serie serie)
        {
            var getSerie = contexto.Set<Serie>().FirstOrDefault(x => x.Id == serie.Id);
            if(getSerie == null)
            {
                return false;
            }
            getSerie.Nome = serie.Nome;
            contexto.Set<Serie>().Update(getSerie);
            contexto.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            //var teste = contexto.Set<Serie>().Include(x => x.ListaTemporada);
            var getSerie = contexto.Set<Serie>().FirstOrDefault(x => x.Id == id);
            if(getSerie == null)
            {
                return false;
            }
            contexto.Set<Serie>().Remove(getSerie);
            contexto.SaveChanges();
            return true;
        }
    }
}
