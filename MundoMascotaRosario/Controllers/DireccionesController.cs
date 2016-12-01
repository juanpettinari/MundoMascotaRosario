using System.Data.Entity;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using MundoMascotaRosario.DAL;
using MundoMascotaRosario.Models;

namespace MundoMascotaRosario.Controllers
{
    public class DireccionesController : Controller
    {
        private readonly MMRContext _db = new MMRContext();

        // GET: Direcciones
        public async Task<ActionResult> Index()
        {
            var direcciones = _db.Direcciones.Include(d => d.Ciudad);
            return View(await direcciones.ToListAsync());
        }

        // GET: Direcciones/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Direccion direccion = await _db.Direcciones.FindAsync(id);
            if (direccion == null)
            {
                return HttpNotFound();
            }
            return View(direccion);
        }

        // GET: Direcciones/Create
        public ActionResult Create()
        {
            ViewBag.CiudadId = new SelectList(_db.Ciudades, "CiudadId", "Descripcion");
            return View();
        }

        // POST: Direcciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "DireccionId,CiudadId,Calle,Nro,CodigoPostal")] Direccion direccion)
        {
            if (ModelState.IsValid)
            {
                _db.Direcciones.Add(direccion);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CiudadId = new SelectList(_db.Ciudades, "CiudadId", "Descripcion", direccion.CiudadId);
            return View(direccion);
        }

        // GET: Direcciones/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Direccion direccion = await _db.Direcciones.FindAsync(id);
            if (direccion == null)
            {
                return HttpNotFound();
            }
            ViewBag.CiudadId = new SelectList(_db.Ciudades, "CiudadId", "Descripcion", direccion.CiudadId);
            return View(direccion);
        }

        // POST: Direcciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "DireccionId,CiudadId,Calle,Nro,CodigoPostal")] Direccion direccion)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(direccion).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CiudadId = new SelectList(_db.Ciudades, "CiudadId", "Descripcion", direccion.CiudadId);
            return View(direccion);
        }

        // GET: Direcciones/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Direccion direccion = await _db.Direcciones.FindAsync(id);
            if (direccion == null)
            {
                return HttpNotFound();
            }
            return View(direccion);
        }

        // POST: Direcciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Direccion direccion = await _db.Direcciones.FindAsync(id);
            _db.Direcciones.Remove(direccion);
            await _db.SaveChangesAsync();
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
