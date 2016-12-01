using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MundoMascotaRosario.DAL;

namespace MundoMascotaRosario.Filters
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            using (var db = new MMRContext())
            {
                var controller = (string)httpContext.Request.RequestContext.RouteData.Values["controller"];
                var p = db.Paginas.FirstOrDefault(c => c.Descripcion == controller);
                var user = httpContext.User.Identity.Name;
                var user2 = db.Usuarios.FirstOrDefault(u => u.Email == user);
                if (user2 != null)
                {
                    if (p != null)
                    {
                        var rP = db.Perfiles.Find(user2.RolId, p.PaginaId);
                        if (rP != null)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        public string RedirectUrl = "~/Perfiles/Unauthorized";

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            base.HandleUnauthorizedRequest(filterContext);

            if (filterContext.RequestContext.HttpContext.User.Identity.IsAuthenticated)
            {
                filterContext.Result = new RedirectResult(RedirectUrl);
            }
        }
    }
}
