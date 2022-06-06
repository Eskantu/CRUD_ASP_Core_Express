using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonasWebCore.Models;
using PersonasWebCore.Servicios.Interfaces;

namespace PersonasWebCore.Controllers
{
    public class PersonaController : Controller
    {
        private readonly IPersonaManager _personaManager;
        public PersonaController(IPersonaManager personaManager)
        {
            _personaManager = personaManager;
        }
        // GET: Persona
        public ActionResult Index()
        {
            return View(_personaManager.Obtener());
        }

        // GET: Persona/Details/5
        public ActionResult Details(int id)
        {
            return View(_personaManager.SearchById(id));
        }

        // GET: Persona/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Persona/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
;
                _personaManager.Crear(new Persona().CreateModel(collection));
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Persona/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_personaManager.SearchById(id));
        }

        // POST: Persona/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                _personaManager.Actualizar(new Persona().CreateModel(collection));

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(_personaManager.SearchById(id));
            }
        }

        // GET: Persona/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_personaManager.SearchById(id));
        }

        // POST: Persona/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _personaManager.Eliminar(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(_personaManager.SearchById(id));
            }
        }
    }
}