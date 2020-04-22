using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieMark.Repository;
using static MovieMark.Models.DatabaseMode;
using static MovieMark.Models.EpisodioViewModels;

namespace MovieMark.Controllers
{
    public class EpisodioController : Controller
    {
        private readonly IEpisodioRepository episodioRepository;

        public EpisodioController(IEpisodioRepository episodioRepository)
        {
            this.episodioRepository = episodioRepository;
        }

        // GET: Episodio
        public ActionResult Index()
        {
            return View();
        }

        // GET: Episodio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Episodio/Create
        public ActionResult Create(int id)
        {
            return View(new EpisodioCreateViewModel() 
            { 
                TemporadaId = id
            });
        }

        // POST: Episodio/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EpisodioCreateViewModel model)
        {
            try
            {
                episodioRepository.Insert(new Episodio() 
                { 
                    Nome = model.Nome,
                    TemporadaId = model.TemporadaId
                });

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Episodio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Episodio/Edit/5
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

        // GET: Episodio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Episodio/Delete/5
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