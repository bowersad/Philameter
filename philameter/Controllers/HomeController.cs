using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using philameter.DAL;
using philameter.DAL.Entities;
using philameter.DAL.Repositories;

namespace philameter.Controllers
{
    public class HomeController : Controller
    {
        private PhilaModelService  service;

        public HomeController()
        {
            service = new PhilaModelService();
        }
        

        // GET: Home
        public ActionResult Index()
        {
            var StatsModel = service.Stats.Get();

            return View(StatsModel);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}