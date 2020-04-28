using Emlakcilik.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emlakcilik.Controllers
{
    public class TipController : Controller
    {
        emlakcilikEntities db = new emlakcilikEntities();
        // GET: Tip
        public ActionResult Index()
        {
            var model = db.IlanTip.ToList();
            return View(model);
        }
    }
}