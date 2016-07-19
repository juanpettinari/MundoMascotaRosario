using System.Web.Mvc;
using MundoMascotaRosario.DAL;

namespace MundoMascotaRosario.Controllers
{
    public class CarritoDeComprasController : Controller
    {
        private readonly MMRContext _db = new MMRContext();

        public void AgregarAlCarrito(string producto)
        {

        }






        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }

        public void AgregarProductoAlCarrito(int cantidad, string productoId)
        {
        }
    }
}
