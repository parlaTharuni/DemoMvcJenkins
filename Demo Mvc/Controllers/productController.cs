using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo_Mvc;
using Demo_Mvc.Models;

namespace Demo_Mvc.Controllers
{
    public class productController : Controller
    {
        // GET: product
        public ActionResult Index()
        {
           // return View();
            productsmodel pro = new productsmodel();
            pro.prodid = 1;
            pro.prodname = "abc";
                return View();
        }
    }
}