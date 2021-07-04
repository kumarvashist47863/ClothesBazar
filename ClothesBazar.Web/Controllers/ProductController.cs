using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClothesBazar.Entities;
using ClothesBazar.Services;
namespace ClothesBazar.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductsService productsService = new ProductsService();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// SK: Display all products
        /// </summary>
        /// <returns></returns>
        public ActionResult ProudctTable(string search)
        {

            var products = productsService.GetProduct();
            //products.Where(p => p.Name == search).ToList();
            if (string.IsNullOrEmpty(search) == false)
            {
                products = products.Where(p => p.Name!=null && p.Name.ToLower().Contains(search.ToLower())).ToList();
            }
                //return View(products);
            return PartialView(products);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }


        /// <summary>
        /// Sk: This method is calling Product Service class to save product data into DB
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(Product product)
        {
            productsService.SaveProduct(product);
            return RedirectToAction("ProudctTable");
        }


    }
}