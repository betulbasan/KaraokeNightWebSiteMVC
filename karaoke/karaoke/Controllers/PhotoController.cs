using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using karaoke.Models;
namespace karaoke.Controllers
{
    public class PhotoController : Controller
    {
        // GET: Photo
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Photos.ToList();
            return View(degerler);
        }
    }
}