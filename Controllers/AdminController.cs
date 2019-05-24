using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmolPaws.Data;
using SmolPaws.Models;

namespace SmolPaws.Controllers
{
    public class AdminController : Controller
    {
        ApplicationDbContext context;


        public AdminController(ApplicationDbContext c)
        {
            context = c;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                int UserId = (int)HttpContext.Session.GetInt32("UserId");
                User u = context.Users.FirstOrDefault(i => i.UserId == UserId);
                if (u.IsAdmin)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            return RedirectToAction("Login", "User");

        }

        public IActionResult UserList()
        {
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                int UserId = (int)HttpContext.Session.GetInt32("UserId");
                User u = context.Users.FirstOrDefault(i => i.UserId == UserId);
                if (u.IsAdmin)
                {
                    return View(context.Users);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            return RedirectToAction("Login", "User");


        }

        public IActionResult UserDelete(int Id)
        {
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                int UserId = (int)HttpContext.Session.GetInt32("UserId");
                User u = context.Users.FirstOrDefault(i => i.UserId == UserId);
                if (u.IsAdmin)
                {
                    u = context.Users.FirstOrDefault(i => i.UserId == Id);
                    context.Users.Remove(u);
                    context.SaveChanges();
                    return RedirectToAction("UserList");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            return RedirectToAction("Login", "User");


        }

        public IActionResult AnimalList()
        {
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                int UserId = (int)HttpContext.Session.GetInt32("UserId");
                User u = context.Users.FirstOrDefault(i => i.UserId == UserId);
                if (u.IsAdmin)
                {
                    return View(context.Animals);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            return RedirectToAction("Login", "User");

        }

        public IActionResult AnimalDelete(int Id)
        {
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                int UserId = (int)HttpContext.Session.GetInt32("UserId");
                User u = context.Users.FirstOrDefault(i => i.UserId == UserId);
                if (u.IsAdmin)
                {
                    Animal a = context.Animals.FirstOrDefault(i => i.AnimalId == Id);
                    context.Animals.Remove(a);
                    context.SaveChanges();
                    return RedirectToAction("AnimalList");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            return RedirectToAction("Login", "User");


        }

        public IActionResult DonateList()
        {
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                int UserId = (int)HttpContext.Session.GetInt32("UserId");
                User u = context.Users.FirstOrDefault(i => i.UserId == UserId);
                if (u.IsAdmin)
                {
                    return View(context.Donates);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            return RedirectToAction("Login", "User");

        }
    }
}

