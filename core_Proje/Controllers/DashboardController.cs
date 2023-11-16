 using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_Proje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "İstatistikler";
            ViewBag.v2 = "İstatik Sayfası";
            ViewBag.v3 = "İstatistikler";
            return View();
        }
    }
}
