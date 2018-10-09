using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanQuanAo.Models;

namespace WebBanQuanAo.Controllers
{
    public class QuanAoNuController : Controller
    {
        ShopQuanAoOnlineEntities _db = new ShopQuanAoOnlineEntities();
        // GET: QuanAoNu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult QuanAoNu()
        {
            ViewBag.meta = "san-pham";
            List<Product> cList = _db.Products.Where(x => x.categoryid == 1).ToList();
            return View(cList);
        }

        public ActionResult QuanAoNu1()
        {
            ViewBag.meta = "san-pham";
            List<Product> cList = _db.Products.Where(x => x.categoryid == 1).ToList();
            return View(cList);
        }
    }
}