using DA.IBL;
using DA.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adminwebapp.Controllers
{
    public class DealerController : Controller
    {
        private IDealerRepo se;
        public DealerController(IDealerRepo _se)
        {
            se = _se;
        }
        public ActionResult Index()
        {
            var Dealer = se.GetallDealer();
            return View(Dealer);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(DealerModel c)
        {
            if (ModelState.IsValid)
            {
                se.InsertDealer(c);
            }

            return RedirectToAction("Edit");

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {

            var employee = se.GetDealerById(id);


            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(DealerModel c)
        {

            if (ModelState.IsValid)
            {
                se.UpdateDealer(c);


                return RedirectToAction("Index");

            }

            else
            {
                return View(c);
            }

        }
    }
}
