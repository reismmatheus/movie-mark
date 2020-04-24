using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MovieMark.Models.DatabaseMode;

namespace MovieMark.Models
{
    public class SeriesViewModels
    {
        public class SerieIndex
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public int TemporadaQuantidade { get; set; }
            public int EpisodioQuantidade { get; set; }
        }
        public class SeriesIndexViewModel
        {
            public List<SerieIndex> ListaSerie { get; set; }
            public SeriesIndexViewModel()
            {
                ListaSerie = new List<SerieIndex>();
            }
        }

        public class SeriesDetailsViewModel
        {
            public Serie Serie { get; set; }
            public SeriesDetailsViewModel()
            {
                Serie = new Serie();
            }

        }

        public class SeriesCreateViewModel
        {
            public string Nome { get; set; }
        }


        public class SeriesEditViewModel
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
