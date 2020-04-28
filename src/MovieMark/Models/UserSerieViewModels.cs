using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MovieMark.Models.DatabaseMode;

namespace MovieMark.Models
{
    public class UserSerieViewModels
    {
        public class UserSerieIndexViewModel
        {
            public List<Serie> ListaSerie { get; set; }
            public UserSerieIndexViewModel()
            {
                ListaSerie = new List<Serie>();
            }
        }
        public class UserSerieSubscribeViewModel
        {
            public List<Serie> ListaSerie { get; set; }
            public UserSerieSubscribeViewModel()
            {
                ListaSerie = new List<Serie>();
            }
        }
        public class UserSerieDetailsViewModel
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public List<TemporadaUser> ListaTemporada { get; set; }
            public UserSerieDetailsViewModel()
            {
                ListaTemporada = new List<TemporadaUser>();
            }
        }
        public class TemporadaUser
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public List<EpisodioListItem> ListaEpisodio { get; set; }
            public TemporadaUser()
            {
                ListaEpisodio = new List<EpisodioListItem>();
            }
        }
        public class EpisodioListItem
        {
            public bool Disabled { get; set; }
            public bool Selected { get; set; }
            public string Text { get; set; }
            public string Value { get; set; }
            public int Id { get; set; }
        }
    }
}
