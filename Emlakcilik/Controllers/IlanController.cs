
using Emlakcilik.Models.EntityFramework;
using Emlakcilik.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emlakcilik.Controllers
{
    public class IlanController : Controller
    {
        emlakcilikEntities db = new emlakcilikEntities();
        // GET: Ilan
        public ActionResult Index()
        {
            var model = db.Ilan.ToList();
            return View(model);
        }
         public ActionResult Yeni()
         {
            var model = new IlanFormViewModel()
            {
                Tipler=db.IlanTip.ToList(),
                Gayrimenkuller=db.Gayrimenkul.ToList(),
                Sehirler=db.Sehir.ToList(),
                Ilceler=db.Ilce.ToList()
            };
             return View("IlanForm",model); 
         } 

         public ActionResult Kaydet(Ilan ilan)
        {
         
                if (ilan.IlanId == 0)
                {
                   
                    db.Ilan.Add(ilan);
                    db.SaveChanges();
                }
             
            return RedirectToAction("Index");
        }






    }
}
