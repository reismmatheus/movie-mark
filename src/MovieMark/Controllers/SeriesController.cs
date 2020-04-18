using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieMark.Repository;
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
            model.Serie = serieRepository.GetById(id);
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
            return View();
        }

        // POST: Series/Edit/5
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

        // GET: Series/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Series/Delete/5
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