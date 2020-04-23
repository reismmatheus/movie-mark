using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieMark.Repository;
using System;
using static MovieMark.Models.DatabaseMode;
using static MovieMark.Models.SeriesViewModels;

namespace MovieMark.Controllers
{
    [Authorize]
    public class SeriesController : Controller
    {
        private readonly ISerieRepository serieRepository;
        public SeriesController(ISerieRepository serieRepository)
        {
            this.serieRepository = serieRepository;
        }

        // GET: Series
        public ActionResult Index()
        {
            var model = new SeriesIndexViewModel();
            model.ListaSerie = serieRepository.GetAll();
            return View(model);
        }

        // GET: Series/Details/5
        public ActionResult Details(int id)
        {
            var model = new SeriesDetailsViewModel();
            model.Serie = serieRepository.Get(id);
            return View(model);
        }

        // GET: Series/Create
        public ActionResult Create()
        {
            var model = new SeriesCreateViewModel();
            return View(model);
        }

        // POST: Series/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SeriesCreateViewModel model)
        {
            try
            {
                serieRepository.Insert(new Serie() 
                { 
                    Nome = model.Nome
                });

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Series/Edit/5
        public ActionResult Edit(int id)
        {
            var serie = serieRepository.Get(id);
            return View(new SeriesEditViewModel() 
            { 
                Id = id,
                Nome = serie.Nome
            });
        }

        // POST: Series/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SeriesEditViewModel model)
        {
            var update = serieRepository.Update(new Serie() 
            { 
                Id = model.Id,
                Nome = model.Nome
            });

            return RedirectToAction(nameof(Index));
        }

        // Series/Delete/5
        [HttpDelete]
        //[ValidateAntiForgeryToken]
        public JsonResult Delete(int id)
        {
            var delete = serieRepository.Delete(id);
            if (!delete)
            {
                return Json(new { message = $"", success = false });
            }
            return Json(new { message = $"Série com o ID {id} excluida com sucesso", success = true });
        }
    }
}