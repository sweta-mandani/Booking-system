using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DA.IBL;
using DA.MODEL;
using DS.BL;
using DS.DATA;

namespace Adminwebapp.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerRepo se;
        public CustomersController(ICustomerRepo _se)
        {
            se = _se;
        }
        public ActionResult Index()
        {
            var customer = se.GetallCustomer();
            return View(customer);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CustomerModel c)
        {
            if (ModelState.IsValid)
            {
                se.InsertCustomer(c);
            }
            
            return RedirectToAction("Edit");

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            
                var employee = se.GetCustomerById(id);

            
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(CustomerModel c)
        {

            if (ModelState.IsValid)
            {
                se.UpdateCustomer(c);


                return RedirectToAction("Index");

            }
       
            else
            {
                return View(c);
            }
            
        }


        // GET: Customers/Details/5

    }
}
