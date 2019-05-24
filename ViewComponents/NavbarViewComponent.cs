using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmolPaws.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                ViewBag.isLoggedIn = true;
            }
            else
            {
                ViewBag.isLoggedIn = false;
            }
            return View();
        }

    }
}
