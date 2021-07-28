using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using karaoke.Models;

namespace karaoke.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Events.ToList();
            return View(degerler);
        }
        
        [HttpGet]
        public ActionResult NewEvent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewEvent(Event p)
        {
            c.Events.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult EventSil(int id)
        {
            var b = c.Events.Find(id);
            c.Events.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult EventGetir(int id)
        {
            var bl = c.Events.Find(id);
            return View("EventGetir", bl);
        }
        public ActionResult EventGuncelle(Event b)
        {
            var blg = c.Events.Find(b.ID);
            blg.Aciklama = b.Aciklama;
            blg.Baslik = b.Baslik;
            blg.BlogImage = b.BlogImage;
            blg.Tarih = b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult Menu()
        {
            var degerler = c.Menus.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult NewMenu()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMenu(Menu m)
        {
            c.Menus.Add(m);
            c.SaveChanges();
            return RedirectToAction("Menu");

        }
        public ActionResult MenuSil(int id)
        {
            var m = c.Menus.Find(id);
            c.Menus.Remove(m);
            c.SaveChanges();
            return RedirectToAction("Menu");
        }
        public ActionResult MenuGetir(int id)
        {
            var m = c.Menus.Find(id);
            return View("MenuGetir", m);
        }
        [Authorize]
        public ActionResult Drink()
        {
            var degerler = c.Drinks.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult NewDrink()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewDrink(Drink d)
        {
            c.Drinks.Add(d);
            c.SaveChanges();
            return RedirectToAction("Drink");

        }
        public ActionResult DrinkSil(int id)
        {
            var d = c.Drinks.Find(id);
            c.Drinks.Remove(d);
            c.SaveChanges();
            return RedirectToAction("Drink");
        }
        public ActionResult DrinkGetir(int id)
        {
            var d = c.Drinks.Find(id);
            return View("DrinkGetir", d);
        }
        [Authorize]
        public ActionResult Room()
        {
            var degerler = c.Rooms.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult NewRoom()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewRoom(Room r)
        {
            c.Rooms.Add(r);
            c.SaveChanges();
            return RedirectToAction("Room");

        }
        public ActionResult RoomSil(int id)
        {
            var r = c.Rooms.Find(id);
            c.Rooms.Remove(r);
            c.SaveChanges();
            return RedirectToAction("Room");
        }
        public ActionResult RoomGetir(int id)
        {
            var r = c.Rooms.Find(id);
            return View("RoomGetir", r);
        }
        [Authorize]
        public ActionResult Photo()
        {
            var degerler = c.Photos.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult NewPhoto()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewPhoto(Photo p)
        {
            c.Photos.Add(p);
            c.SaveChanges();
            return RedirectToAction("Photo");

        }
        public ActionResult PhotoSil(int id)
        {
            var p = c.Photos.Find(id);
            c.Photos.Remove(p);
            c.SaveChanges();
            return RedirectToAction("Photo");
        }
        public ActionResult PhotoGetir(int id)
        {
            var p = c.Photos.Find(id);
            return View("PhotoGetir", p);
        }
        [Authorize]
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var p = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(p);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yr = c.Yorumlars.Find(id);
            return View("YorumGetir", yr);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = c.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Mail = y.Mail;
            yrm.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}