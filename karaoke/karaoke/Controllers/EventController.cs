using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using karaoke.Models;

namespace karaoke.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        Context c = new Context();
        public ActionResult Index()
        {
            var eventler = c.Events.ToList();
            return View(eventler);
        }
        EventYorum ey = new EventYorum();
        public ActionResult EventDetay(int id)
        {
            //var eventbul = c.Events.Where(x => x.ID == id).ToList();
            ey.Deger1 = c.Events.Where(x => x.ID == id).ToList();
            ey.Deger2 = c.Yorumlars.Where(x => x.Eventid == id).ToList();
            return View(ey);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();

        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();

        }

    }
}