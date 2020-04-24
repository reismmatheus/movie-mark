using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MovieMark.Models.DatabaseMode;

namespace MovieMark.Models
{
    public class TemporadaViewModels
    {
        public class TemporadaIndex
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public int SerieId { get; set; }
            public string SerieNome { get; set; }
            public int EpisodioQuantidade { get; set; }
        }

        public class TemporadaIndexViewModel
        {
            public List<TemporadaIndex> ListaTemporada { get; set; }
            public TemporadaIndexViewModel()
            {
                ListaTemporada = new List<TemporadaIndex>();
            }
        }

        public class TemporadaDetailsViewModel
        {
            public Temporada Temporada { get; set; }
            public TemporadaDetailsViewModel()
            {
                Temporada = new Temporada();
            }
        }
        public class TemporadaCreateViewModel
        {
            public string Nome { get; set; }
            public int SerieId { get; set; }
        }

        public class TemporadaEditViewModel
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
