using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web.Mvc;
using System.Web.Security;
using MundoMascotaRosario.Common;
using MundoMascotaRosario.DAL;
using MundoMascotaRosario.Models;
using MundoMascotaRosario.Models.ViewModels;

namespace MundoMascotaRosario.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly MMRContext _db = new MMRContext();


        public ActionResult LogIn()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
                
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(CuentaUsuarioVM cuentaUsuarioVM)
        {
            if (cuentaUsuarioVM.Email != null && cuentaUsuarioVM.Password != null)
            {
                if (ModelState.IsValid)
                {
                    var miUsuario = _db.Usuarios.FirstOrDefault(u => u.Email == cuentaUsuarioVM.Email);
                    // TODO Agregar "isactive" al usuario
                    if (miUsuario != null) //Usuario Encontrado
                    {
                        if (!miUsuario.Estado)
                        {
                            ModelState.AddModelError("","El usuario no está habilitado.");
                        }
                        if (!Hash.ValidatePassword(cuentaUsuarioVM.Password, miUsuario.Password))
                        {
                            //Todo Admin reset password si se olvida el user la pass.
                            ModelState.AddModelError("", "La contraseña es incorrecta, vuelva a escribirla.");
                        }
                        else
                        {
                            FormsAuthentication.SetAuthCookie(cuentaUsuarioVM.Email, false);
                            RolesMenusController.DevolverMenus(miUsuario);
                            return RedirectToAction("Index", "Home");
                            //TODO REENVIAR A LA PAGINA DE CHECKOUT SI SE LOGUEÓ DESP DE VENIR DEL CHECKOUT o de REGISTRARSE PARA CHECKOUT.   
                        }
                    }
                    else //EL USUARIO NO FUE ENCONTRADO
                    {
                        ModelState.AddModelError("",
                            "No existe el email: " + cuentaUsuarioVM.Email + " en nuestra base de datos");
                    }
                }
                else
                    ModelState.AddModelError("", "Ocurrió un error inesperado.");
                return View(cuentaUsuarioVM);
            }
            ModelState.AddModelError("", "Ingrese Email y Contraseña.");
            return View(cuentaUsuarioVM);
        }


        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session["Menu"] = null;
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(RegistrationVM model)
        {
            //TODO COMPROBAR QUE EL MAIL NO EXISTA EN LA BD
            var firstOrDefault = _db.Roles.FirstOrDefault(r => r.Descripcion == "Cliente");
            if (firstOrDefault != null)
                model.RolId = firstOrDefault.RolId;
            if (ModelState.IsValid)
            {
                if (model.Password != null)
                {
                    var usuario = new Usuario
                    {
                        Email = model.Email,
                        Password = model.Password,
                        RolId = model.RolId,
                        Nombre = model.Nombre,
                        Apellido = model.Apellido,
                        Telefono = model.Telefono,
                        NroDocumento = model.NroDocumento,
                        Estado = model.Estado
                    };
                    usuario.Password = Hash.CreateHash(model.Password);
                    _db.Usuarios.Add(usuario);
                    _db.SaveChanges();
                    return RedirectToAction("LogIn", "Usuarios");
                }
            }
            return View(model);
        }








        // GET: Usuarios
        public async Task<ActionResult> Index()
        {
            return View(await _db.Usuarios.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = await _db.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }


        // GET: Usuarios/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = await _db.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "UsuarioId,Email,Password,Nombre,Apellido,Telefono,NroDocumento,Estado")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(usuario).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = await _db.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Usuario usuario = await _db.Usuarios.FindAsync(id);
            _db.Usuarios.Remove(usuario);
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
