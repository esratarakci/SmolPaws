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
    public class UserController : Controller
    {

        ApplicationDbContext context;
      
        public UserController(ApplicationDbContext c)
        {
            context = c;
          
        }

        public IActionResult Index()
        {
          
            return View();
        }
        public IActionResult Register()
        {
            ViewBag.UserExist = false;
            return View();
        }

        [HttpPost]
        public IActionResult Register(User u)
        {
            if (ModelState.IsValid)
            {
                if (context.Users.FirstOrDefault(i => i.UserName == u.UserName) == null)
                {
                    u.IsAdmin = false;
                    context.Users.Add(u);
                    context.SaveChanges();
                    User b = context.Users.FirstOrDefault(i => i.UserName == u.UserName);
                    HttpContext.Session.SetInt32("UserId", b.UserId);
                    return RedirectToAction("Add", "Animal");

                }
                else
                {
                    ViewBag.UserExist = true;
                }
               
            }
            return View();
        }

        public IActionResult Login()
        {
             
            if (HttpContext.Session.GetInt32("UserId") !=null && (int)HttpContext.Session.GetInt32("UserId")> 0)
                return RedirectToAction("Add", "Animal");
            
            return View();
            
        }

        [HttpPost]
        public IActionResult Login(User u)
        {

            if (u.UserName != "" && u.Password != "")
            {
                User b = context.Users.FirstOrDefault(i => i.UserName == u.UserName);
                if (b != null && u.Password == b.Password)
                {
                    ViewBag.Success = true;
                    HttpContext.Session.SetInt32("UserId", b.UserId);
                    return RedirectToAction("Index", "Home");
                }
                else
                    ViewBag.Success = false;
            }
            return View();
        }
                
            

        
        

        [HttpGet]
        public IActionResult Profile()
        {
            ViewBag.UserExist = false;
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                
                User b = context.Users.FirstOrDefault(i => i.UserId ==((int)(HttpContext.Session.GetInt32("UserId"))));

              return View(b);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        
        [HttpPost]
        public IActionResult Profile(User u)
        {
            ViewBag.UserExist = false;
            if (HttpContext.Session.GetInt32("UserId") != null)
           {
               User b = context.Users.FirstOrDefault(i => i.UserId == ((int)(HttpContext.Session.GetInt32("UserId"))));
                if (u.FirstName != null && u.LastName != "")
                {
                    b.FirstName = u.FirstName;
                }
                if (u.LastName != null && u.LastName != "") 
                {
                    b.LastName = u.LastName;
                }
                if(u.EMail != null && u.LastName != "")
                {
                    b.EMail = u.EMail;
                }
                if (u.UserName != null && u.LastName != "")
                {
                    if (context.Users.FirstOrDefault(i => i.UserName == u.UserName) == null)
                        b.UserName = u.UserName;

                    else
                    {
                        ViewBag.UserExist = true;
                    }
                }
               context.Users.Update(b);
               context.SaveChanges();
               return View(b);
           }
           else
           {
               return RedirectToAction("Login");
           }
           }

          

       
        


        public IActionResult ChangePassword()
        {
            ViewBag.WrongPassword = false;
            if (HttpContext.Session.GetInt32("UserId") != null)
            { 
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePassword pw)
        {
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                User b = context.Users.FirstOrDefault(i => i.UserId == ((int)(HttpContext.Session.GetInt32("UserId"))));
                if (b.Password == pw.OldPassword)
                {
                    b.Password = pw.NewPassword;
                    context.Users.Update(b);
                    context.SaveChanges();
                    return RedirectToAction("Profile");
                }
                else
                {
                    ViewBag.WrongPassword = true;
                    return View();
                    
                }
            }
            return RedirectToAction("Login");

        }
      public IActionResult Logout()
        {
            HttpContext.Session.Remove("UserId");
            return RedirectToAction("Index","Home");
        }  

    }
    
}