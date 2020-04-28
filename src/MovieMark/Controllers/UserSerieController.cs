using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieMark.Repository;
using static MovieMark.Models.DatabaseMode;
using static MovieMark.Models.UserSerieViewModels;

namespace MovieMark.Controllers
{
    [Authorize]
    public class UserSerieController : Controller
    {
        private readonly ISerieRepository serieRepository;
        private readonly IUserSerieRepository userSerieRepository;
        private readonly IUserTemporadaEpisodioRepositoy userTemporadaEpisodioRepositoy;
        public UserSerieController(IUserSerieRepository userSerieRepository, ISerieRepository serieRepository, IUserTemporadaEpisodioRepositoy userTemporadaEpisodioRepositoy)
        {
            this.userSerieRepository = userSerieRepository;
            this.serieRepository = serieRepository;
            this.userTemporadaEpisodioRepositoy = userTemporadaEpisodioRepositoy;
        }
        // GET: UserSerie
        public ActionResult Index()
        {
            var model = new UserSerieIndexViewModel();
            var series = userSerieRepository.GetByIdUser(User.FindFirstValue(ClaimTypes.NameIdentifier));
            foreach (var serie in series)
            {
                var getSerie = serieRepository.Get(serie.SerieId);
                model.ListaSerie.Add(new Serie()
                {
                    Id = serie.SerieId,
                    Nome = getSerie.Nome
                });
            }
            return View(model);
        }

        public ActionResult Subscribe()
        {
            var model = new UserSerieSubscribeViewModel();
            var series = serieRepository.GetAll();
            model.ListaSerie = series;
            return View(model);
        }

        [HttpPost]
        public ActionResult Subscribe(int id)
        {
            userSerieRepository.Insert(new UserSerie()
            {
                SerieId = id,
                AspNetUsersId = User.FindFirstValue(ClaimTypes.NameIdentifier)
            });
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public JsonResult Unsubscribe(int id)
        {
            return null;
        }

        // GET: UserSerie/Details/5
        public ActionResult Details(int id)
        {
            var model = new UserSerieDetailsViewModel();
            var userSerie = userSerieRepository.Get(id);
            var serie = serieRepository.Get(id);
            model.Nome = serie.Nome;
            foreach (var temporada in serie.ListaTemporada)
            {
                var lista = new List<EpisodioListItem>();
                foreach (var episodio in temporada.ListaEpisodio)
                {
                    lista.Add(new EpisodioListItem()
                    {
                        Text = episodio.Nome,
                        Id = episodio.Id
                    });
                }
                model.ListaTemporada.Add(new TemporadaUser()
                {
                    ListaEpisodio = lista,
                    Nome = temporada.Nome,
                    Id = temporada.Id
                });
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Details(UserSerieDetailsViewModel model)
        {
            foreach (var temporada in model.ListaTemporada)
            {
                foreach (var episodio in temporada.ListaEpisodio.Where(x => x.Selected))
                {
                    userTemporadaEpisodioRepositoy.Insert(new UserTemporadaEpisodio()
                    {
                        EpisodioId = episodio.Id,
                        TemporadaId = temporada.Id,
                        UserSerieId = model.Id
                    });
                }
            }
            return null;
        }
    }
}