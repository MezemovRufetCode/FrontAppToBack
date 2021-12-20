using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontApp.Controllers
{
    public class ProgressBarPageController:Controller
    {
        public ActionResult ProgressBar()
        {
            return View();
        }
    }
}
