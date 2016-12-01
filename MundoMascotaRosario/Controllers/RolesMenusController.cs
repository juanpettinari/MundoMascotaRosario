using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MundoMascotaRosario.DAL;
using MundoMascotaRosario.Models;
using MundoMascotaRosario.Models.ViewModels;

namespace MundoMascotaRosario.Controllers
{
    public class RolesMenusController : Controller
    {
        private readonly MMRContext _db = new MMRContext();

        public static void DevolverMenus(Usuario usuario)
        {
            using (MMRContext db = new MMRContext())
            {
                var menuVM = new MenuVM();

                var listaPadre = new List<RolMenu>();
                var rolesMenus = db.RolesMenus.Where(rm => rm.Rol.RolId == usuario.RolId).ToList();
                foreach (var rolmenu in rolesMenus)
                {
                    if (rolmenu.Menu.PadreId == null)
                    {
                        listaPadre.Add(rolmenu);
                    }
                }
                menuVM.PadresVm = new List<PadreVM>();
                foreach (var padre in listaPadre)
                {
                    var listaHijo = db.Menus.Where(m => m.PadreId == padre.MenuId).ToList();
                    var lineaDePadre = new PadreVM
                    {
                        PadreId = padre.MenuId,
                        TextoMenu = padre.Menu.TextoMenu,
                        HijosVm = new List<HijoVM>()
                    };
                    foreach (var hijo in listaHijo)
                    {
                        var lineaDeHijo = new HijoVM
                        {
                            HijoId = hijo.MenuId,
                            TextoSubMenu = hijo.TextoMenu,
                            Url = hijo.Url
                        };

                        lineaDePadre.HijosVm.Add(lineaDeHijo);
                    }

                    menuVM.PadresVm.Add(lineaDePadre);

                    

                }

                System.Web.HttpContext.Current.Session["Menu"] = menuVM;

            }
        }
                


        // GET: RolesMenus
        public ActionResult Index()
        {
            var rolesMenus = _db.RolesMenus.Include(r => r.Menu).Include(r => r.Rol);
            return View(rolesMenus.ToList());
        }

        // GET: RolesMenus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RolMenu rolMenu = _db.RolesMenus.Find(id);
            if (rolMenu == null)
            {
                return HttpNotFound();
            }
            return View(rolMenu);
        }

        // GET: RolesMenus/Create
        public ActionResult Create()
        {
            ViewBag.MenuId = new SelectList(_db.Menus, "MenuId", "TextoMenu");
            ViewBag.RolId = new SelectList(_db.Roles, "RolId", "Descripcion");
            return View();
        }

        // POST: RolesMenus/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RolId,MenuId")] RolMenu rolMenu)
        {
            if (ModelState.IsValid)
            {
                _db.RolesMenus.Add(rolMenu);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MenuId = new SelectList(_db.Menus, "MenuId", "Url", rolMenu.MenuId);
            ViewBag.RolId = new SelectList(_db.Roles, "RolId", "Descripcion", rolMenu.RolId);
            return View(rolMenu);
        }

        // GET: RolesMenus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RolMenu rolMenu = _db.RolesMenus.Find(id);
            if (rolMenu == null)
            {
                return HttpNotFound();
            }
            ViewBag.MenuId = new SelectList(_db.Menus, "MenuId", "Url", rolMenu.MenuId);
            ViewBag.RolId = new SelectList(_db.Roles, "RolId", "Descripcion", rolMenu.RolId);
            return View(rolMenu);
        }

        // POST: RolesMenus/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RolId,MenuId")] RolMenu rolMenu)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(rolMenu).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MenuId = new SelectList(_db.Menus, "MenuId", "Url", rolMenu.MenuId);
            ViewBag.RolId = new SelectList(_db.Roles, "RolId", "Descripcion", rolMenu.RolId);
            return View(rolMenu);
        }

        // GET: RolesMenus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RolMenu rolMenu = _db.RolesMenus.Find(id);
            if (rolMenu == null)
            {
                return HttpNotFound();
            }
            return View(rolMenu);
        }

        // POST: RolesMenus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RolMenu rolMenu = _db.RolesMenus.Find(id);
            _db.RolesMenus.Remove(rolMenu);
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
