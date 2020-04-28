using Emlakcilik.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emlakcilik.Controllers
{
    public class EmlakController : Controller
    {
        emlakcilikEntities db = new emlakcilikEntities();
        // GET: Emlak
        public ActionResult Index()
        {
            var model = db.Gayrimenkul.ToList();
            return View(model);
        }
        [HttpGet]
        public ActionResult Yeni()
        {
            return View("EmlakForm");
        }
        [HttpPost]
        public ActionResult Kaydet(Gayrimenkul gayrimenkul)
        {
            if(gayrimenkul.Id==0)
            {
                db.Gayrimenkul.Add(gayrimenkul);
            }
            else
            {
                var guncelGM = db.Gayrimenkul.Find(gayrimenkul.Id);
                if(guncelGM==null)
                {
                    return HttpNotFound();
                }

                guncelGM.OdaSayisi = gayrimenkul.OdaSayisi;
                guncelGM.Adres = gayrimenkul.Adres;
                guncelGM.InsaatTarih = gayrimenkul.InsaatTarih;
                guncelGM.KatSayisi = gayrimenkul.KatSayisi;
                guncelGM.Isitma = gayrimenkul.Isitma;
                guncelGM.Esya = gayrimenkul.Esya;
                guncelGM.Boya = gayrimenkul.Boya;
                guncelGM.Havuz = gayrimenkul.Havuz;
            }
            
            db.SaveChanges();
            return RedirectToAction("Index", "Emlak");  // emlak controllerındaki Index view ina dön
        }

        public ActionResult Guncelle(int id)
        {
            var model = db.Gayrimenkul.Find(id);
            if (model == null)
                return HttpNotFound();
            return View("EmlakForm",model);
        }

        public ActionResult Sil(int id)
        {
            var silGm = db.Gayrimenkul.Find(id);
            if (silGm == null)
                return HttpNotFound();
            db.Gayrimenkul.Remove(silGm);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}