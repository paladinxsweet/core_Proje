using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_Proje.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());

   
        [HttpGet]
        public IActionResult Index()
        {


            ViewBag.v1 = "Düzenleme";
            ViewBag.v2 = "Hakkımda";
            ViewBag.v3 = "Hakkımda Sayfası";
            var values = aboutManager.TGetByID(1);
            return View(values);


        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            aboutManager.TUptade(about);
            return RedirectToAction("Index", "Default");

        }
    }
}
