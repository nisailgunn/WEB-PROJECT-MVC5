using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmlakSitesi.Models.Entity;

namespace EmlakSitesi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        dbemlakEntities db = new dbemlakEntities();
        public ActionResult Index()
        {
            var deger = db.TBL_EVLER.ToList();
            return View(deger);
        }
    }
}