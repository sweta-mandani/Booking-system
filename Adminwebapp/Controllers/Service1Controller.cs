using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

using DA.IBL;
using DS.BL;
using DS.DATA;

namespace Adminwebapp.Controllers
{
    public class Service1Controller : Controller
    {
        private IServiceRepo db;
        public Service1Controller()
        {
            this.db = new ServiceRepo(new ServiceEntities2());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Service1 s)
        {
            db.InsertService(s);
            return RedirectToAction("Create","Mechanics");

        }
        
    }
}
