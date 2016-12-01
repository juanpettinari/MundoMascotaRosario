using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MundoMascotaRosario.DAL;
using MundoMascotaRosario.Models;

namespace MundoMascotaRosario.Controllers
{
    public class OrdenesDeCompraController : Controller
    {
        private readonly MMRContext _db = new MMRContext();

        // GET: OrdenesDeCompra
        public ActionResult Index()
        {
            var ordenesDeCompra = _db.OrdenesDeCompra.Include(o => o.Usuario);
            return View(ordenesDeCompra.ToList());
        }

        // GET: OrdenesDeCompra/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdenDeCompra ordenDeCompra = _db.OrdenesDeCompra.Find(id);
            if (ordenDeCompra == null)
            {
                return HttpNotFound();
            }
            return View(ordenDeCompra);
        }

        // GET: OrdenesDeCompra/Create
        public ActionResult Create()
        {
            ViewBag.UsuarioId = new SelectList(_db.Usuarios, "UsuarioId", "Email");
            return View();
        }

        // POST: OrdenesDeCompra/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrdenId,UsuarioId,FechaCompra,DireccionDeEnvioId,FormaDePago,Estado,TotalDecimal")] OrdenDeCompra ordenDeCompra)
        {
            if (ModelState.IsValid)
            {
                _db.OrdenesDeCompra.Add(ordenDeCompra);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UsuarioId = new SelectList(_db.Usuarios, "UsuarioId", "Email", ordenDeCompra.UsuarioId);
            return View(ordenDeCompra);
        }

        // GET: OrdenesDeCompra/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdenDeCompra ordenDeCompra = _db.OrdenesDeCompra.Find(id);
            if (ordenDeCompra == null)
            {
                return HttpNotFound();
            }
            ViewBag.UsuarioId = new SelectList(_db.Usuarios, "UsuarioId", "Email", ordenDeCompra.UsuarioId);
            return View(ordenDeCompra);
        }

        // POST: OrdenesDeCompra/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrdenId,UsuarioId,FechaCompra,DireccionDeEnvioId,FormaDePago,Estado,TotalDecimal")] OrdenDeCompra ordenDeCompra)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(ordenDeCompra).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UsuarioId = new SelectList(_db.Usuarios, "UsuarioId", "Email", ordenDeCompra.UsuarioId);
            return View(ordenDeCompra);
        }

        // GET: OrdenesDeCompra/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrdenDeCompra ordenDeCompra = _db.OrdenesDeCompra.Find(id);
            if (ordenDeCompra == null)
            {
                return HttpNotFound();
            }
            return View(ordenDeCompra);
        }

        // POST: OrdenesDeCompra/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrdenDeCompra ordenDeCompra = _db.OrdenesDeCompra.Find(id);
            _db.OrdenesDeCompra.Remove(ordenDeCompra);
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
