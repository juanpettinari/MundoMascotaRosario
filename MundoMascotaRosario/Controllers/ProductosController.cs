using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MundoMascotaRosario.DAL;
using MundoMascotaRosario.Models;

namespace MundoMascotaRosario.Controllers
{
    public class ProductosController : Controller
    {
        private readonly MMRContext _db = new MMRContext();

        //GET

        public async Task<ActionResult> ListadoProductos()
        {
            return View(await _db.Productos.ToListAsync());
        }
            


        public ActionResult BuscarProductos(string busqueda)
        {
            var productos = _db.Productos.Where(p => p.Descripcion.Contains(busqueda) || p.Marca.Contains(busqueda) || p.Animal.Contains(busqueda));
            return View("ListadoProductos", productos);

        }
        // GET: Productos
        public async Task<ActionResult> Index()
        {
            return View(await _db.Productos.ToListAsync());
        }

        // GET: Productos/Details/5
        public async Task<ActionResult> DetalleDeProducto(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producto producto = await _db.Productos.FindAsync(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        [HttpPost]
        public ActionResult DetalleDeProducto(int cantidad, string productoId)
        {

            CarritoDeComprasController.AgregarProductoAlCarrito(cantidad, productoId);
            return View();
        }

        // GET: Productos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Productos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ProductoId,Animal,Descripcion,Marca,Stock,PrecioDecimal,Imagen")] Producto producto)
        {
            if (!ModelState.IsValid)
                return View(producto);

            _db.Productos.Add(producto);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: Productos/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var producto = await _db.Productos.FindAsync(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        // POST: Productos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ProductoId,Animal,Descripcion,Marca,Stock,PrecioDecimal,Imagen")] Producto producto)
        {
            if (!ModelState.IsValid)
                return View(producto);
            _db.Entry(producto).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        // GET: Productos/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var producto = await _db.Productos.FindAsync(id);
            if (producto == null)
            {
                return HttpNotFound();
            }
            return View(producto);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            var producto = await _db.Productos.FindAsync(id);
            _db.Productos.Remove(producto);
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
