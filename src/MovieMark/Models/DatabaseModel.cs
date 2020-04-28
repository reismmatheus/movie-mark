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
            public Serie()
            {
                ListaTemporada = new List<Temporada>();
            }
        }

        public class Temporada : BaseModel
        {
            [Required]
            public string Nome { get; set; }
            public List<Episodio> ListaEpisodio { get; set; }
            public int SerieId { get; set; }
            public Temporada()
            {
                ListaEpisodio = new List<Episodio>();
            }
        }

        public class Episodio : BaseModel
        {
            [Required]
            public string Nome { get; set; }
            public int TemporadaId { get; set; }
        }

        public class UserSerie : BaseModel
        {
            public string AspNetUsersId { get; set; }
            public int SerieId { get; set; }
            public List<UserTemporadaEpisodio> ListaTemporadaEpisodio { get; set; }
        }

        public class UserTemporadaEpisodio : BaseModel
        {
            public int TemporadaId { get; set; }
            public int EpisodioId { get; set; }
            public int UserSerieId { get; set; }
            public UserSerie UserSerie { get; set; }
        }
    }
}
