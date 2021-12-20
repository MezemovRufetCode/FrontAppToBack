using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontApp.Controllers
{
    public class TabsController:Controller
    {
        public ActionResult TabsPage()
        {
            return View();
        }
    }
}
