using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MundoMascotaRosario.DAL;
using MundoMascotaRosario.Models;

namespace MundoMascotaRosario.Controllers
{
    public class CiudadesController : Controller
    {
        private readonly MMRContext _db = new MMRContext();

        // GET: Ciudades
        public ActionResult Index()
        {
            var ciudades = _db.Ciudades.Include(c => c.Provincia);
            return View(ciudades.ToList());
        }

        // GET: Ciudades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ciudad ciudad = _db.Ciudades.Find(id);
            if (ciudad == null)
            {
                return HttpNotFound();
            }
            return View(ciudad);
        }

        // GET: Ciudades/Create
        public ActionResult Create()
        {
            ViewBag.ProvinciaId = new SelectList(_db.Provincias, "ProvinciaId", "Descripcion");
            return View();
        }

        // POST: Ciudades/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CiudadId,Descripcion,ProvinciaId")] Ciudad ciudad)
        {
            if (ModelState.IsValid)
            {
                _db.Ciudades.Add(ciudad);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProvinciaId = new SelectList(_db.Provincias, "ProvinciaId", "Descripcion", ciudad.ProvinciaId);
            return View(ciudad);
        }

        // GET: Ciudades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ciudad ciudad = _db.Ciudades.Find(id);
            if (ciudad == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProvinciaId = new SelectList(_db.Provincias, "ProvinciaId", "Descripcion", ciudad.ProvinciaId);
            return View(ciudad);
        }

        // POST: Ciudades/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CiudadId,Descripcion,ProvinciaId")] Ciudad ciudad)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(ciudad).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProvinciaId = new SelectList(_db.Provincias, "ProvinciaId", "Descripcion", ciudad.ProvinciaId);
            return View(ciudad);
        }

        // GET: Ciudades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ciudad ciudad = _db.Ciudades.Find(id);
            if (ciudad == null)
            {
                return HttpNotFound();
            }
            return View(ciudad);
        }

        // POST: Ciudades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ciudad ciudad = _db.Ciudades.Find(id);
            _db.Ciudades.Remove(ciudad);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
