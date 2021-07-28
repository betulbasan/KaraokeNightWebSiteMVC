using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using karaoke.Models;
namespace karaoke.Controllers
{
    public class RoomController : Controller
    {
        // GET: Room
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Rooms.ToList();
            return View(degerler);
        }
    }
}