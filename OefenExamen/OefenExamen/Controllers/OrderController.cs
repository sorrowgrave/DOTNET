using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repository;
using OefenExamen.DataLayer;
using OefenExamen.DomainClasses;

namespace OefenExamen.Controllers
{
    
    [RequireHttps]
    [Authorize]
    public class OrderController : Controller
    {
        private SimpleProductsRepository _productsRepo;
        Dictionary<string, Order> ordered = new Dictionary<string, Order>();
        Products product = new Products();
        public OrderController()
        {
            _productsRepo = new SimpleProductsRepository();
        }
        // GET: Order
        public ActionResult Index()
        {
            var products = _productsRepo.GetProducts();
            return View(products);
        }

        [Route("Order/Details/{id}")]
        public ActionResult Details(string id)
        {
            var orders = _productsRepo.GetProductById(id);
            return View(orders);

        }

        
        [HttpPost]
        public ActionResult OrderNow(Products product)
        {
            if (Session["orders"] != null)
                ordered = (Dictionary<string, Order>) Session["orders"];

            //if (Session["product"] != null)
            //    product = (Products)Session["product"];

            int quantity = Int32.Parse( Request["quantity"]);

            if (ordered.ContainsKey(product.ProductID))
            {
                    ordered[product.ProductID].quantity = quantity;
            }
            else
            {
                Order newOrder = new Order(product, quantity);

                ordered.Add(product.ProductID, newOrder);
            }


            Session["orders"] = ordered;

            return RedirectToAction("Index");
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
