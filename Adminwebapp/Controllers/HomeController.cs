
using DA.IBL;
using DS.BL;
using DS.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adminwebapp.Controllers
{
    public class HomeController : Controller
    {
        private IDealerRepo de;
        public HomeController()
        {
            this.de = new DealerRepo(new ServiceEntities2());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(DealerModel d)
        {
            de.InsertDealer(d);
            return RedirectToAction("Create", "Service1");
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}