
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaBlog.Models;
using PruebaBlog.Services;

namespace PruebaBlog.Controllers
{
    public class UsuariosController : Controller
    {

        private BlogMuroRepository _repo;

        public UsuariosController()
        {
            _repo = new BlogMuroRepository();
        }


        // GET: Usuario
        public ActionResult Index()
        {
            var model = _repo.ObtenerTodos();
            return View(model);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuarios model)
        {
            //try
            //{
            if (ModelState.IsValid)
            {
                _repo.Crear(model);
                return RedirectToAction("Index");
            }
            //}
            //catch 
            //{
            //return View("Create", model);
            //}
            return View(model);
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuario/Edit/5
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

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
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
