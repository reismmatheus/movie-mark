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
        private readonly ITemporadaRepository temporadaRepository;
        public TemporadaController(ITemporadaRepository temporadaRepository)
        {
            this.temporadaRepository = temporadaRepository;
        }

        // GET: Temporada
        public ActionResult Index()
        {
            return View();
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
            try
            {
                temporadaRepository.Insert(new Temporada()
                {
                    Nome = model.Nome,
                    SerieId = model.SerieId
                });

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Temporada/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Temporada/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
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