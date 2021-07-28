using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using karaoke.Models;
namespace karaoke.Controllers
{
    public class DrinkController : Controller
    {
        // GET: Drink
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Drinks.ToList();
            return View(degerler);
        }
    }
}