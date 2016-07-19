using System.Linq;
using System.Web.Mvc;
using MundoMascotaRosario.DAL;
using System.Threading.Tasks;
using System.Data.Entity;
using MundoMascotaRosario.Models;
using System.Collections.Generic;

namespace MundoMascotaRosario.Controllers
{
    public class HomeController : Controller
    {
        private readonly MMRContext _db = new MMRContext();

        public async Task<ActionResult> Index()
        {
            List<Producto> productos = await _db.Productos.OrderBy(p => p.Marca).ToListAsync();
            return View(productos.Take(4));
        }

        [HttpPost]
        public ActionResult Index(string busqueda)
        {
            return RedirectToAction("BuscarProductos", "Productos", new {busqueda});
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var prod = _db.Productos.FirstOrDefault(p => p.Animal == "Perro");
            if (prod != null) prod.Descripcion = "asd";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}