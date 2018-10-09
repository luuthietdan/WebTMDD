using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanQuanAo.Models;
namespace WebBanQuanAo.Controllers
{
    public class NewsController : Controller
    {
        ShopQuanAoOnlineEntities6 _db = new ShopQuanAoOnlineEntities6();
        // GET: New
        public ActionResult Index()
        {
            var v = from t in _db.News
                    where t.hide == true
                    orderby t.order descending
                    select t;
            return View(v.ToList());
        }
    }
}