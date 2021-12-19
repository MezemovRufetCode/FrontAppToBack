using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontApp.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductList()
        {
            return View();
        }
        public ActionResult TabsPage()
        {
            return View();
        }
        public ActionResult AccourdionPage()
        {
            return View();
        }
        public ActionResult ShopListPage()
        {
            return View();
        }
        public ActionResult ProgressBarPage()
        {
            return View();
        }

    }
}
