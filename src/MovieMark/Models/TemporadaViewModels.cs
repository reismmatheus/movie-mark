using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MovieMark.Models.DatabaseMode;

namespace MovieMark.Models
{
    public class TemporadaViewModels
    {
        public class TemporadaIndexViewModel
        {
            public List<Temporada> ListaTemporada { get; set; }
            public TemporadaIndexViewModel()
            {
                ListaTemporada = new List<Temporada>();
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
    }
}
