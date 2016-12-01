using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MundoMascotaRosario.DAL;
using MundoMascotaRosario.Models;

namespace MundoMascotaRosario.Controllers
{
    public class PerfilesController : Controller
    {
        private readonly MMRContext _db = new MMRContext();

        public ActionResult Unauthorized()
        {
            return View();
        }



        // GET: Perfiles
        public ActionResult Index()
        {
            var perfiles = _db.Perfiles.Include(p => p.Permiso).Include(p => p.Rol);
            return View(perfiles.ToList());
        }

        // GET: Perfiles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Perfil perfil = _db.Perfiles.Find(id);
            if (perfil == null)
            {
                return HttpNotFound();
            }
            return View(perfil);
        }

        // GET: Perfiles/Create
        public ActionResult Create()
        {
            ViewBag.PermisoId = new SelectList(_db.Permisos, "PermisoId", "Descripcion");
            ViewBag.RolId = new SelectList(_db.Roles, "RolId", "Descripcion");
            return View();
        }

        // POST: Perfiles/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RolId,PermisoId")] Perfil perfil)
        {
            if (ModelState.IsValid)
            {
                _db.Perfiles.Add(perfil);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PermisoId = new SelectList(_db.Permisos, "PermisoId", "Descripcion", perfil.PermisoId);
            ViewBag.RolId = new SelectList(_db.Roles, "RolId", "Descripcion", perfil.RolId);
            return View(perfil);
        }

        // GET: Perfiles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Perfil perfil = _db.Perfiles.Find(id);
            if (perfil == null)
            {
                return HttpNotFound();
            }
            ViewBag.PermisoId = new SelectList(_db.Permisos, "PermisoId", "Descripcion", perfil.PermisoId);
            ViewBag.RolId = new SelectList(_db.Roles, "RolId", "Descripcion", perfil.RolId);
            return View(perfil);
        }

        // POST: Perfiles/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RolId,PermisoId")] Perfil perfil)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(perfil).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PermisoId = new SelectList(_db.Permisos, "PermisoId", "Descripcion", perfil.PermisoId);
            ViewBag.RolId = new SelectList(_db.Roles, "RolId", "Descripcion", perfil.RolId);
            return View(perfil);
        }

        // GET: Perfiles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Perfil perfil = _db.Perfiles.Find(id);
            if (perfil == null)
            {
                return HttpNotFound();
            }
            return View(perfil);
        }

        // POST: Perfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Perfil perfil = _db.Perfiles.Find(id);
            _db.Perfiles.Remove(perfil);
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
