using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMark.Models
{
    public class EpisodioViewModels
    {
        public class EpisodioIndex
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string TemporadaNome { get; set; }
            public string SerieNome { get; set; }
        }
        public class EpisodioIndexViewModel
        {
            public List<EpisodioIndex> ListaEpisodio { get; set; }
            public EpisodioIndexViewModel()
            {
                ListaEpisodio = new List<EpisodioIndex>();
            }
        }
        public class EpisodioCreateViewModel
        {
            public string Nome { get; set; }
            public int TemporadaId { get; set; }
        }

        public class EpisodioEditViewModel
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
