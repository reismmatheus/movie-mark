using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace MovieMark.Models
{
    public class DatabaseMode
    {
        [DataContract]
        public class BaseModel
        {
            [DataMember]
            public int Id { get; set; }
        }

        public class Serie : BaseModel
        {
            [Required]
            public string Nome { get; set; }
            public List<Temporada> ListaTemporada { get; set; }
        }

        public class Temporada : BaseModel
        {
            [Required]
            public string Nome { get; set; }
            public List<Episodio> ListaEpisodio { get; set; }
            public int SerieId { get; set; }
        }

        public class Episodio : BaseModel
        {
            [Required]
            public string Nome { get; set; }
            public int TemporadaId { get; set; }
        }
    }
}
