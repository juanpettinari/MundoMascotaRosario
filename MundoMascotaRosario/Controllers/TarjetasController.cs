using System.Data.Entity;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using MundoMascotaRosario.DAL;
using MundoMascotaRosario.Models;

namespace MundoMascotaRosario.Controllers
{
    public class TarjetasController : Controller
    {
        private readonly MMRContext _db = new MMRContext();

        // GET: Tarjetas
        public async Task<ActionResult> Index()
        {
            return View(await _db.Tarjetas.ToListAsync());
        }

        // GET: Tarjetas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarjeta tarjeta = await _db.Tarjetas.FindAsync(id);
            if (tarjeta == null)
            {
                return HttpNotFound();
            }
            return View(tarjeta);
        }

        // GET: Tarjetas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tarjetas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "TarjetaId,TipoDeTarjeta,NumeroTarjeta,MesExpiracion,AnoExpiracion,NombreTitular,DniTitular,CodigoSeguridad,Estado")] Tarjeta tarjeta)
        {
            if (ModelState.IsValid)
            {
                _db.Tarjetas.Add(tarjeta);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tarjeta);
        }

        // GET: Tarjetas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarjeta tarjeta = await _db.Tarjetas.FindAsync(id);
            if (tarjeta == null)
            {
                return HttpNotFound();
            }
            return View(tarjeta);
        }

        // POST: Tarjetas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "TarjetaId,TipoDeTarjeta,NumeroTarjeta,MesExpiracion,AnoExpiracion,NombreTitular,DniTitular,CodigoSeguridad,Estado")] Tarjeta tarjeta)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(tarjeta).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tarjeta);
        }

        // GET: Tarjetas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tarjeta tarjeta = await _db.Tarjetas.FindAsync(id);
            if (tarjeta == null)
            {
                return HttpNotFound();
            }
            return View(tarjeta);
        }

        // POST: Tarjetas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Tarjeta tarjeta = await _db.Tarjetas.FindAsync(id);
            _db.Tarjetas.Remove(tarjeta);
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
