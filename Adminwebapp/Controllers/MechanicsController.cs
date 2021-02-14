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
    public class MechanicsController : Controller
    {
        private IMechanicRepo me;
        public MechanicsController()
        {
            this.me = new MechanicRepo(new ServiceEntities2());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Mechanic d)
        {
            me.InsertMechanic(d);
            return RedirectToAction("Create", "Customers");

        }
    }
}
