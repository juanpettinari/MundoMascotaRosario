using System;
using System.Web.Mvc;
using MundoMascotaRosario.DAL;
using MundoMascotaRosario.Models;
using WebGrease.Css.Extensions;

namespace MundoMascotaRosario.Controllers
{
    public class CarritoDeComprasController : Controller
    {
        private readonly MMRContext _db = new MMRContext();

        public ActionResult VerCarrito()
        {
            if (Session["carrito"] != null)
            {
                var carrito = Session["carrito"] as CarritoDeCompra;

                return View(carrito);
            }
            else
            {
                ViewBag.img = Url.Content("~/Content/Img/shopping.jpg");
                return View();
            }
        }


        public void LimpiarSesion()
        {
            Session["carrito"] = null;
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
