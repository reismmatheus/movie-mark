using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieMark.Repository;
using static MovieMark.Models.DatabaseMode;
using static MovieMark.Models.TemporadaViewModels;

namespace MovieMark.Controllers
{
    [Authorize]
    public class TemporadaController : Controller
    {
        private readonly ISerieRepository serieRepository;
        private readonly ITemporadaRepository temporadaRepository;
        private readonly IEpisodioRepository episodioRepository;
        public TemporadaController(ITemporadaRepository temporadaRepository, ISerieRepository serieRepository, IEpisodioRepository episodioRepository)
        {
            this.serieRepository = serieRepository;
            this.temporadaRepository = temporadaRepository;
            this.episodioRepository = episodioRepository;
        }

        // GET: Temporada
        public ActionResult Index(int id = 0)
        {
            var model = new TemporadaIndexViewModel();
            var temporadas = temporadaRepository.GetAll();
            foreach (var temporada in temporadas)
            {
                var getTemporada = episodioRepository.GetByTemporadaId(temporada.Id);
                var getSerie = serieRepository.Get(temporada.SerieId);
                model.ListaTemporada.Add(new TemporadaIndex()
                {
                    Id = temporada.Id,
                    Nome = temporada.Nome,
                    SerieId = temporada.SerieId,
                    SerieNome = getSerie.Nome,
                    EpisodioQuantidade = getTemporada.Count
                });
            }
            return View(model);
        }

        // GET: Temporada/Details/5
        public ActionResult Details(int id)
        {
            var model = new TemporadaDetailsViewModel();
            var temporada = temporadaRepository.Get(id);
            model.Temporada = temporada;
            return View(model);
        }

        // GET: Temporada/Create
        public ActionResult Create(int id)
        {
            var model = new TemporadaCreateViewModel()
            {
                SerieId = id
            };
            return View(model);
        }

        // POST: Temporada/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TemporadaCreateViewModel model)
        {
            temporadaRepository.Insert(new Temporada()
            {
                Nome = model.Nome,
                SerieId = model.SerieId
            });

            return RedirectToAction("Details", "Series", new { id = model.SerieId });
        }

        // GET: Temporada/Edit/5
        public ActionResult Edit(int id)
        {
            var temporada = temporadaRepository.Get(id);
            return View(new TemporadaEditViewModel() 
            { 
                Id = temporada.Id,
                Nome = temporada.Nome
            });
        }

        // POST: Temporada/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TemporadaEditViewModel model)
        {
            var update = temporadaRepository.Update(new Temporada()
            {
                Id = model.Id,
                Nome = model.Nome
            });
            if (update)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Temporada/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Temporada/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}