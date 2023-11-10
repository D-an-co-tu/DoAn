using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn.Models;

namespace DoAn.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        DBShopDunkEntities database = new DBShopDunkEntities();
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult SearchOption(double min = double.MinValue, double max = double.MaxValue)
        {
            var list = database.Products.Where(p => (double)p.Price >= min && (double)p.Price <= max).ToList();
            return View(list);
        }
    }
}