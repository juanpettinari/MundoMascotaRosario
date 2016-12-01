using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MundoMascotaRosario.DAL;
using MundoMascotaRosario.Models;

namespace MundoMascotaRosario.Controllers
{
    public class PaginasController : Controller
    {
        private readonly MMRContext _db = new MMRContext();

        // GET: Paginas
        public ActionResult Index()
        {
            return View(_db.Paginas.ToList());
        }

        // GET: Paginas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pagina pagina = _db.Paginas.Find(id);
            if (pagina == null)
            {
                return HttpNotFound();
            }
            return View(pagina);
        }

        // GET: Paginas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Paginas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PaginaId,Descripcion")] Pagina pagina)
        {
            if (ModelState.IsValid)
            {
                _db.Paginas.Add(pagina);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pagina);
        }

        // GET: Paginas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pagina pagina = _db.Paginas.Find(id);
            if (pagina == null)
            {
                return HttpNotFound();
            }
            return View(pagina);
        }

        // POST: Paginas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PaginaId,Descripcion")] Pagina pagina)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(pagina).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pagina);
        }

        // GET: Paginas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pagina pagina = _db.Paginas.Find(id);
            if (pagina == null)
            {
                return HttpNotFound();
            }
            return View(pagina);
        }

        // POST: Paginas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pagina pagina = _db.Paginas.Find(id);
            _db.Paginas.Remove(pagina);
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
