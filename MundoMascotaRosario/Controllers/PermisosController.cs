using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MundoMascotaRosario.DAL;
using MundoMascotaRosario.Models;

namespace MundoMascotaRosario.Controllers
{
    public class PermisosController : Controller
    {
        private readonly MMRContext _db = new MMRContext();

        // GET: Permisos
        public ActionResult Index()
        {
            var permisos = _db.Permisos.Include(p => p.Pagina);
            return View(permisos.ToList());
        }

        // GET: Permisos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Permiso permiso = _db.Permisos.Find(id);
            if (permiso == null)
            {
                return HttpNotFound();
            }
            return View(permiso);
        }

        // GET: Permisos/Create
        public ActionResult Create()
        {
            ViewBag.PaginaId = new SelectList(_db.Paginas, "PaginaId", "Descripcion");
            return View();
        }

        // POST: Permisos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PermisoId,Descripcion,PaginaId")] Permiso permiso)
        {
            if (ModelState.IsValid)
            {
                _db.Permisos.Add(permiso);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PaginaId = new SelectList(_db.Paginas, "PaginaId", "Descripcion", permiso.PaginaId);
            return View(permiso);
        }

        // GET: Permisos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Permiso permiso = _db.Permisos.Find(id);
            if (permiso == null)
            {
                return HttpNotFound();
            }
            ViewBag.PaginaId = new SelectList(_db.Paginas, "PaginaId", "Descripcion", permiso.PaginaId);
            return View(permiso);
        }

        // POST: Permisos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PermisoId,Descripcion,PaginaId")] Permiso permiso)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(permiso).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PaginaId = new SelectList(_db.Paginas, "PaginaId", "Descripcion", permiso.PaginaId);
            return View(permiso);
        }

        // GET: Permisos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Permiso permiso = _db.Permisos.Find(id);
            if (permiso == null)
            {
                return HttpNotFound();
            }
            return View(permiso);
        }

        // POST: Permisos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Permiso permiso = _db.Permisos.Find(id);
            _db.Permisos.Remove(permiso);
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
