using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_Proje.ViewComponents.Dashboard
{
    public class Last5Projects:ViewComponent
    {


        public IViewComponentResult Invoke()
        {

            return View();

        }
    }
}
