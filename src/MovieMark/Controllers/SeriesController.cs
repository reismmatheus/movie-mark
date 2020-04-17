using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieMark.Repository;

namespace MovieMark.Controllers
{
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
            var teste = serieRepository.GetAll();
            return View();
        }

        // GET: Series/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Series/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Series/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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