using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmolPaws.Data;
using SmolPaws.Models;

namespace SmolPaws.Controllers
{
    public class AnimalController : Controller
    {
        ApplicationDbContext context;
        private readonly IHostingEnvironment _environment;
       
        

        public AnimalController(ApplicationDbContext c,IHostingEnvironment appEnvironment)
        {
            context = c;
            _environment = appEnvironment;
        }

        public IActionResult List()
        {
            if(HttpContext.Session.GetInt32("UserId") != null)
            {
                ViewBag.OwnerId = HttpContext.Session.GetInt32("UserId");
            }
            var list = context.Animals.OrderByDescending(i => i.Datetime);
            return View(list);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Add(Animal a)
        {


            if (ModelState.IsValid)
            {
                if (HttpContext.Session.GetInt32("UserId") != null)
                {
                    var newFileName = string.Empty;
                    var fileName = string.Empty;
                    string PathDB = string.Empty;
                    var files = HttpContext.Request.Form.Files;
                    foreach (var file in files)
                    {
                        if (file.Length > 0)
                        {
                            //Getting FileName
                            fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

                            //Assigning Unique Filename (Guid)
                            var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                            //Getting file Extension
                            var FileExtension = Path.GetExtension(fileName);

                            // concating  FileName + FileExtension
                            newFileName = myUniqueFileName + FileExtension;

                            // Combines two strings into a path.
                            fileName = Path.Combine(_environment.WebRootPath, "AnimalImages") + $@"\{newFileName}";

                            // if you want to store path of folder in database
                            PathDB = "AnimalImages/" + newFileName;

                            using (FileStream fs = System.IO.File.Create(fileName))
                            {
                                file.CopyTo(fs);
                                fs.Flush();
                            }
                        }
                        else
                        {

                            return RedirectToAction("Login", "User");
                        }
                        a.ImgPath = PathDB;

                        a.UserId = (int)HttpContext.Session.GetInt32("UserId");
                        a.CurrentMoney = 0;
                        a.Datetime = DateTime.Now;
                        context.Animals.Add(a);
                        context.SaveChanges();
                        return RedirectToAction("List");


                    }
                    
                }

                    
                }
            return View();
        }

        [HttpGet]
        public IActionResult Donate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Donate(Donate d, int id)
        {
            if (ModelState.IsValid)
            {
                Animal a = context.Animals.FirstOrDefault(i => i.AnimalId == id);
                
                a.CurrentMoney += d.Donation;
                context.Animals.Update(a);
                context.Donates.Add(d);
                context.SaveChanges();
                return View("donated", a);
            }
            return View();
        }

       

        public IActionResult Delete(int Id)
        {
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                int UserId = (int)HttpContext.Session.GetInt32("UserId");
                Animal a = context.Animals.FirstOrDefault(i => i.AnimalId == Id);
                if(a.UserId == UserId)
                {
                    context.Animals.Remove(a);
                    context.SaveChanges();
                    return RedirectToAction("List");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Login","User");
            }

               
        }
    }
}