using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MovieMark.Models.DatabaseMode;

namespace MovieMark.Models
{
    public class SeriesViewModels
    {
        public class SeriesIndexViewModel
        {
            public List<Serie> ListaSerie { get; set; }
            public SeriesIndexViewModel()
            {
                ListaSerie = new List<Serie>();
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
    }
}
